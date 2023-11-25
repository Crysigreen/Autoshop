namespace Autoshop.Models
{
    public class Offer : BaseEntity
    {
        private string Description { get; set;}
        private string ImageUrl { get; set;}
        private int Mileage { get; set;}
        private decimal Price { get; set;}
        private int Year { get; set;}
        private Model Model { get; set;}
        private User User { get; set;}
    }
}
