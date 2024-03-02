using GetYourDrink.Data.Models.Configurations;
using Microsoft.EntityFrameworkCore;

namespace GetYourDrink.Data.Models
{
    [EntityTypeConfiguration(typeof(ProductConfiguration))]

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }
        public double Alcohol { get; set; }
        public int Stock { get; set; }
        public string Picture { get; set; }
        public string Descritpion { get; set; }
        public string Origin { get; set; }
        public float Price { get; set; }

    }

    public enum Category
    {
        Wine,
        Cognac,
        Vodka,
        Rum,
        Brandy,
        Whiskey,
        Champagne,
        Beer,
        Cider
    }
}
