using System.Diagnostics.CodeAnalysis;
using DataAccessLibrary.Models;

namespace DataAccessLibrary;

public class SqlCrud
{
    private readonly string _connectionString;
    private SqlDataAccess db = new SqlDataAccess();

    public SqlCrud(string connectionString)
    {
        _connectionString = connectionString;
    }

    public List<BasicContactModel> GetAllContacts()
    {
        string? sql = "SELECT Id, FirstName, LastName FROM Contacts";
        return db.LoadData<BasicContactModel, dynamic>(sql, new { }, _connectionString);
    }

    public FullContactModel? GetFullContactById(int id)
    {
        string? sql = "SELECT Id, FirstName, LastName FROM Contacts where Id = @Id";
        FullContactModel output = new FullContactModel();

        output.BasicInfo = db.LoadData<BasicContactModel, dynamic>(
                sql,
                new { Id = id },
                _connectionString
            )
            .FirstOrDefault();

        if (output.BasicInfo == null)
        {
            // Do something to tell the user that the record was not found
            // throw new Exception("User not found");
            return null;
        }
        sql =
            @"SELECT e.*, ce.* FROM [EmailAddresses] e INNER JOIN [ContactEmail] ce ON ce.EmailAddressId = e.Id WHERE ce.ContactId = @Id;";
        output.EmailAddresses = db.LoadData<EmailAddressModel, dynamic>(
                sql,
                new { Id = id },
                _connectionString
            );
        sql =
            @"SELECT e.*, ce.* FROM [EmailAddresses] e INNER JOIN [ContactEmail] ce ON ce.EmailAddressId = e.Id WHERE ce.ContactId = @Id;";
        output.PhoneNumbers = db.LoadData<PhoneNumberModel, dynamic>(
                sql,
                new { Id = id },
                _connectionString
            );
        return output;


    }


    public void CreateContact(FullContactModel contact)
    {
        // Save the basic contact
        string? sql = "INSERT INTO Contacts (FirstName, LastName) values (@FirstName, @LastName);";
        db.SaveData(sql, new { FirstName = contact.BasicInfo.FirstName, LastName = contact.BasicInfo.LastName }, _connectionString);

        // Get the ID number of the contact
        sql = "SELECT Id FROM Contacts WHERE FirstName = @FirstName AND LastName = @LastName;";
        var contactId = db.LoadData<IdLookupModel, dynamic>(sql, new { FirstName = contact.BasicInfo.FirstName, LastName = contact.BasicInfo.LastName }, _connectionString).First().Id;


        foreach (var phoneNumber in contact.PhoneNumbers)

        {
            if (phoneNumber.Id == 0)
            {
                sql = "INSERT INTO PhoneNumbers (PhoneNumber) VALUES (@PhoneNumber);";
                db.SaveData(sql, new { phoneNumber.PhoneNumber }, _connectionString);

                sql = "SELECT Id FROM PhoneNumbers WHERE PhoneNumber = @PhoneNumber;";

                phoneNumber.Id = db.LoadData<IdLookupModel, dynamic>(sql, new { phoneNumber.PhoneNumber }, _connectionString).First().Id;
            }
            sql = "INSERT INTO ContactPhoneNumbers (ContactId, PhoneNumberId) VALUES (@ContactId, @PhoneNumberId)";
            db.SaveData(sql, new { ContactId = contactId, PhoneNumberId = phoneNumber.Id }, _connectionString);

        }

        foreach (var email in contact.EmailAddresses)

        {
            if (email.Id == 0)
            {
                sql = "INSERT INTO EmailAddresses (EmailAddress) VALUES (@EmailAddress);";
                db.SaveData(sql, new { email.EmailAddress }, _connectionString);

                sql = "SELECT Id FROM EmailAddresses WHERE EmailAddress = @EmailAddress";
                email.Id = db.LoadData<IdLookupModel, dynamic>(sql, new { email.EmailAddress }, _connectionString).First().Id;
            }
            sql = "INSERT INTO ContactEmail (ContactId, EmailAddressId) VALUES (@ContactId, @EmailAddressId)";
            db.SaveData(sql, new { ContactId = contactId, EmailAddressId = email.Id }, _connectionString);

        }
    }

    public void UpdateContactName(BasicContactModel contact)
    {
        string sql = "UPDATE Contacts SET FirstName = @FirstName, LastName = @LastName WHERE Id = @Id";
        db.SaveData(sql, contact, _connectionString);
    }

    public void RemovePhoneNumberFromContact(int contactId, int phoneNumberId)
    {
        // Find all of the usages of the phone number id
        // If 1, then delete link and phone number
        // If > 1, then delete link for contact

        string sql = "SELECT Id, ContactId, PhoneNumberId FROM ContactPhoneNumbers WHERE PhoneNumberId =  @PhoneNumberId;";
        var links = db.LoadData<ContactPhoneNumberModel, dynamic>(sql, new { PhoneNumberId = phoneNumberId }, _connectionString);

        sql = "DELETE FROM ContactPhoneNumbers WHERE PhoneNumberId =  @PhoneNumberId AND ContactId = @ContactId";
        db.SaveData(sql, new { PhoneNumberId = phoneNumberId, ContactId = contactId }, _connectionString);

        if (links.Count == 1)
        {
            sql = "DELETE FROM PhoneNumbers WHERE Id = @PhoneNumberId;";
            db.SaveData(sql, new { PhoneNumberId = phoneNumberId }, _connectionString);
        }
    }
}
