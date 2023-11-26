namespace Autoshop.Models
{
    public class Offer : BaseEntity
    {
        public string Description { get; set;}
        public string ImageUrl { get; set;}
        public int Mileage { get; set;}
        public decimal Price { get; set;}
        public int Year { get; set;}
        public Guid ModelId { get; set;}
        public Model Model { get; set;}
        public Guid UserId { get; set;}
        public User User { get; set;}

        public Offer(string description, string imageUrl, int mileage, decimal price, int year, Guid modelId, Guid userId)
        {
            this.Description = description;
            this.ImageUrl = imageUrl;
            this.Mileage = mileage;
            this.Price = price;
            this.Year = year;
            this.ModelId = modelId;
            this.UserId = userId;
        }
    }
}
