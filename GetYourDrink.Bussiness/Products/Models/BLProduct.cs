using GetYourDrink.Data.Models;

namespace GetYourDrink.Bussiness.Products.Models
{
    public class BLProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }
        public double Alcohol { get; set; }
        public int Stock { get; set; }
        public string Picture { get; set; }
        public string Descritpion { get; set; }
        public string Origin { get; set; }
    }
}
