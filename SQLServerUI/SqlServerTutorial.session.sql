-- INSERT INTO [EmailAddresses] ([EmailAddress])
-- VALUES ('muyiwadosunmu@gmail.com'),
--        ('smithrowe@gmail.com'),
--        ('Aliciakeys@yahoo.com');

-- INSERT INTO [PhoneNumbers] ([PhoneNumber])
-- VALUES ('555-1212'),
--        ('555-1234'),
--        ('555-6543');

-- INSERT INTO [ContactEmail] ([ContactId],[EmailAddressId])
-- VALUES (1,1), (1,2);


-- INSERT INTO [ContactPhoneNumbers] ([ContactId],[PhoneNumberId])
-- VALUES (1,1),(1,2);

-- SELECT e.*, ce.* FROM [EmailAddresses] e INNER JOIN [ContactEmail] ce ON ce.EmailAddressId = e.Id WHERE ce.ContactId = 1;

-- SELECT * FROM ContactEmail;

-- SELECT * FROM EmailAddresses;

SELECT [Id], [FirstName], [LastName] FROM [Contacts];