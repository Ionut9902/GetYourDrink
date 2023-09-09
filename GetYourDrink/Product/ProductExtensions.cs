using GetYourDrink.Api.Product.Requests;
using GetYourDrink.Bussiness.Products.Commands;
using GetYourDrink.Bussiness.Products.Queries;

namespace GetYourDrink.Api.Product
{
    public static class ProductExtensions
    {
        public static AddNewProductCommand ToCommand(this AddNewProductRequest request)
        {
            return new AddNewProductCommand
            {
                Name = request.Name,
                Category = request.Category,
                Alcohol = request.Alcohol,
                Stock = request.Stock,
                Picture = request.Picture,
                Description = request.Description,
                Origin = request.Origin
            };
        }

        public static GetProductByIdQuery ToQuery(this GetProductByIdRequest request)
        {
            return new GetProductByIdQuery
            {
                Id = request.Id
            };
        }

        public static GetProductsQuery ToQuery(this GetProductsRequest request)
        {
            return new GetProductsQuery
            {
                Page = request.Page
            };
        }

        public static AddToFavouritesCommand ToCommand(this AddToFavouritesRequest request)
        {
            return new AddToFavouritesCommand
            {
                ProductId = request.ProductId,
                UserId = request.UserId,
            };
        }
    }
}
