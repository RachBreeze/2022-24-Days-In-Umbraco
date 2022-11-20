using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using PetApi.Model;
using System.ComponentModel.DataAnnotations;

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
        [HttpPut]
        public IActionResult Update([FromBody]Pet request)
        {
            return null;
        }

    }
}
