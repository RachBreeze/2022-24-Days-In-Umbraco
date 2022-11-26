using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Validations;
using PetApi.Model;
using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel.DataAnnotations;
using System.Net.Mime;

namespace PetAPI.Controllers
{
    /// <summary>
    /// Everything about your Pets
    /// </summary>
    [ApiController]
    [Route("[controller]/[action]")]
    public class PetController : ControllerBase
    {
        /// <summary>
        /// Update an existing  pet by id
        /// </summary>
        /// <param name="request">Update an existing pet in the store</param>
        /// <response code="200">Successful operation</response>
        /// <response code="404">Pet not found</response>
        /// <response code="400">Invalid Id Supplied</response>
        [HttpPut]
        [Consumes("application/json")]
        [Produces("application/json")]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(Pet),Description = "Successful operation")]
        [SwaggerResponse(StatusCodes.Status400BadRequest,  Description = "Invalid Id Supplied")]
        [SwaggerResponse(StatusCodes.Status404NotFound, Description = "Pet not found")]
        [SwaggerResponse(StatusCodes.Status405MethodNotAllowed, Description = "Validation exception")]
        public IActionResult Update([Required][FromBody] Pet request)
        {
            if (request == null)
            {
                return BadRequest("Invalid Id Supplied");
           }
            if (request.Id <= 0)
            {
                return NotFound("Pet not found");
            }

            return Ok(request);
        }
        [HttpGet("{petId:long}")]
        public IActionResult Get([Required] int petId)
        {

            var foundPet = new Pet();
            return CreatedAtAction(nameof(Get), foundPet);
        }
    }
}
