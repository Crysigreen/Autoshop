namespace Autoshop.Models
{
    public class User : BaseEntity
    {
        private string Username { get; set;}
        private string Password { get; set;}
        private string FirstName { get; set;}
        private string LastName { get; set;}
        private string Email { get; set;}
        private string Phone { get; set;}
        private bool isActive { get; set;}
        private bool isAdmin { get;}

    }
}
