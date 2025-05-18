using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Petfolio.Application.UseCases.Pet.Delete;
using Petfolio.Application.UseCases.Pet.GetAll;
using Petfolio.Application.UseCases.Pet.GetById;
using Petfolio.Application.UseCases.Pet.Register;
using Petfolio.Application.UseCases.Pet.Update;
using Petfolio.Communication.Requests;
using Petfolio.Communication.Responses;

namespace Petfolio.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(typeof(ResponseRegisterPetJson), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
        
        public IActionResult Register([FromBody] RequestPetJson request)
        {
            var registerPetUseCase = new RegisterPetUseCase();
            var response = registerPetUseCase.Execute(request);
            
            return Created(string.Empty, response);
        }

        [HttpPut]
        [Route("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
        
        public IActionResult Update([FromRoute] int id, [FromBody] RequestPetJson request)
        {
            var updatePetUseCase = new UpdatePetUseCase();
            updatePetUseCase.Execute(id, request);
            
            return NoContent();
        }

        [HttpGet]
        [ProducesResponseType(typeof(ResponseAllPetsJson), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status204NoContent)]
        public IActionResult GetAll([FromQuery] RequestPetJson request)
        {
            var useCase = new GetAllPetsUseCase();
            var response = useCase.Execute();
            
            if (response.Pets.Count == 0)
            {
                return NoContent();
            }

            return Ok(response);
        }
        
        [HttpGet]
        [Route("{id:int}")]
        [ProducesResponseType(typeof(ResponsePetJson), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetById([FromRoute] int id)
        {
            var useCase = new GetPetByIdUseCase();
            var response = useCase.Execute(id);
            
            if (response == null)
            {
                return NotFound();
            }
        
            return Ok(response);
        }
        
        [HttpDelete]
        [Route("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Delete([FromRoute] int id)
        {
            var useCase = new DeletePetUseCase();
            var deleted = useCase.Execute(id);
            
            if (!deleted)
            {
                return NotFound();
            }
        
            return NoContent();
        }
    }
}
