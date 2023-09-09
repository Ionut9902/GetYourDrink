using GetYourDrink.Api.Product;
using GetYourDrink.Api.Product.Requests;
using GetYourDrink.Bussiness.Products.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace GetYourDrink.Api.Controllers
{

    [Route("api/[controller]/{action}")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [HttpPost("{add-products}")]

        public async Task<bool> AddNewProduct(AddNewProductRequest request)
        {
            return await _mediator.Send(request.ToCommand());
        }

        [HttpGet]
        [HttpGet("{get-product-by-id}")]
        public async Task<BLProduct> GetProductById(GetProductByIdRequest request)
        {
            return await _mediator.Send(request.ToQuery());
        }

        [HttpGet]
        [HttpGet("{get-all-products}")]
        public async Task<ProductPage> GetProducts(GetProductsRequest request)
        {
            return await _mediator.Send(request.ToQuery());
        }

        [HttpPost]
        [HttpPost("{add-to-favourites}")]
        public async Task<bool> AddToFavourites(AddToFavouritesRequest request)
        {
            return await _mediator.Send(request.ToCommand());
        }
    }

}
