namespace Autoshop.Models
{
    public class Brand : BaseEntity
    {
        public string? Name { get; set;}

        public Brand(string? name)
        {
            this.Name = name;
        }
    }

    
}

