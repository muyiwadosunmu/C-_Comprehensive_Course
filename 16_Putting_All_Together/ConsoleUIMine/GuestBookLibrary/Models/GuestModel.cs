

namespace GuestBookLibrary.Models
{
    public class GuestModel
    {
        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? Message { get; set; }

        public string? GuestInfo
        {
            get
            {
                return $"{FirstName} {LastName} {Message}";
            }
        }



    }
}