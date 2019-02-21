using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace SwaggerApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        /// <summary>
        /// Get current Assembly name
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// GET
        /// {
        ///     "id": 1
        /// }
        /// </remarks>
        /// <returns>Name of current Assembly</returns>
        /// <response code="200">Success</response>
        /// <response code="404">Not found</response>
        [HttpGet]
        public ActionResult<string> Get()
        {
            return Assembly.GetExecutingAssembly().GetName().Name;
        }
    }
}
