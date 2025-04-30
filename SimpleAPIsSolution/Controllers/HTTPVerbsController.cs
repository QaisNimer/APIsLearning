using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_Operation_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HTTPVerbsController : ControllerBase
    {
        [HttpGet("[action]")]
        public async Task<IActionResult> HTTPGet() {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {

                return StatusCode(500, $"An Error Was Occured: {ex.Message}");
            }
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> HttpPost()
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {

                return StatusCode(500, $"An Error Was Occured: {ex.Message}");
            }
        }

        [HttpPut("[action]")]
        public async Task<IActionResult> HttpPut()
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {

                return StatusCode(500, $"An Error Was Occured: {ex.Message}");
            }
        }
        [HttpPatch("[action]")]
        public async Task<IActionResult> HttpPatch()
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {

                return StatusCode(500, $"An Error Was Occured: {ex.Message}");
            }
        }
        [HttpDelete("[action]")]
        public async Task<IActionResult> HttpDelete()
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {

                return StatusCode(500, $"An Error Was Occured: {ex.Message}");
            }
        }
    }
}
