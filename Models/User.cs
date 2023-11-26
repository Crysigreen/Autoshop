namespace Autoshop.Models
{
    public class User : BaseEntity
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool IsActive { get; set; }
        public bool IsAdmin { get; set; }

        public User(string username, string password, string firstName, string lastName, string email, string phone, bool IsActive, bool IsAdmin)
        {
            this.Username = username;
            this.Password = password;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.Phone = phone;
            this.IsActive = IsActive;
            this.IsAdmin = IsAdmin;
        }

    }
}
