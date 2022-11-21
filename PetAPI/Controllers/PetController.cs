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
        /// <param name="request">Update an existing pet in the store</param>
        [HttpPut]
        public IActionResult Update([Required][FromBody]Pet request)
        {
            return null;
        }
    }
}
