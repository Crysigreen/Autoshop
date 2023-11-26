namespace Autoshop.Models
{
    public class Offer : BaseEntity
    {
        public string Description { get; set;}
        public string ImageUrl { get; set;}
        public int Mileage { get; set;}
        public decimal Price { get; set;}
        public int Year { get; set;}
        public Model Model { get; set;}
        public User User { get; set;}

        public Offer(string description, string imageUrl, int mileage, decimal price, int year, Model model, User user)
        {
            this.Description = description;
            this.ImageUrl = imageUrl;
            this.Mileage = mileage;
            this.Price = price;
            this.Year = year;
            this.Model = model;
            this.User = user;
        }
    }
}
