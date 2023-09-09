using GetYourDrink.Api.Requests;
using GetYourDrink.Api.Users;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace GetYourDrink.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<bool> AddNewUser(AddNewUserRequest request)
        {
            return await _mediator.Send(request.ToQuery());
        }
    }
}
