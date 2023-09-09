namespace GetYourDrink.Bussiness.Products.Models
{
    public class ProductPage
    {
        public List<BLProduct> Products { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
    }
}
