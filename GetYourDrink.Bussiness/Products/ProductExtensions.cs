using GetYourDrink.Bussiness.Products.Models;
using GetYourDrink.Data.Models;

namespace GetYourDrink.Bussiness.Products
{
    public static class ProductExtensions
    {
        public static IQueryable<BLProduct> ToBLProduct(this IQueryable<Product> query)
        {
            return query.Select(x => new BLProduct
            {
                Id = x.Id,
                Name = x.Name,
                Category = x.Category,
                Alcohol = x.Alcohol,
                Stock = x.Stock,
                Picture = x.Picture,
                Descritpion = x.Descritpion,
                Origin = x.Origin,
            });
        }
    }
}
