using GetYourDrink.Api.Order;
using GetYourDrink.Api.Order.Requests;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace GetYourDrink.Api.Controllers
{
    [Route("api/[controller]/{action}")]
    [ApiController]
    public class OrderController : ControllerBase
    {

        private readonly IMediator _mediator;

        public OrderController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<bool> PlaceNewOrder(PlaceNewOrderRequest request)
        {
            return await _mediator.Send(request.ToCommand());
        }
    }
}
