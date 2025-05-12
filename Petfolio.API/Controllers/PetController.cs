using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Petfolio.Communication.Requests;

namespace Petfolio.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(typeof(RequestRegisterPetsJson), StatusCodes.Status201Created)]
        public IActionResult Register([FromBody] RequestRegisterPetsJson request)
        {
            // Logic to create a pet
            return Created();
        }
    }
}
