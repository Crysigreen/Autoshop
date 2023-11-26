namespace Autoshop.Models
{
    public class Model : BaseEntity
    {
        public string Name { get; set; }
        public Guid BrandId { get; set; }
        public Brand Brand { get; set; }
        public string ImageUrl { get; set; }
        public int StartYear { get; set; }
        public int EndYear { get; set; }
        public Categorys Category { get; set; }


        public Model(string name, Guid brandId, string imageUrl, int startYear, int endYear, Categorys category)
        {
            this.Name = name;
            this.BrandId = brandId;
            this.ImageUrl = imageUrl;
            this.StartYear = startYear;
            this.EndYear = endYear;
            this.Category = category;
        }
    }

    public enum Categorys
    {
        Sedan = 0,
        Hatchback = 1,
        Coupe = 2,
        Convertible = 3,
        SU = 4,
        Crossover = 5,
        Minivan = 6,
        PickupTruck = 7,
        Van = 8,
        Wagon = 9,
        Other = 10
    }
}
