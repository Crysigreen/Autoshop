namespace Autoshop.Models
{
    public class Model : BaseEntity
    {
        private string Name { get; set;}
        private Brands Brand { get; set;}
        private string ImageUrl { get; set;}
        private int StartYear { get; set;}
        private int EndYear { get; set;}
        private Categorys Category { get; set;}

    }

    public enum Categorys
    {
        Sedan,
        Hatchback,
        Coupe,
        Convertible,
        SUV,
        Crossover,
        Minivan,
        PickupTruck,
        Van,
        Wagon,
        Other
    }
}
