using CRUD_Operation_API.DTO_s;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_Operation_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestGetFromRouteController : ControllerBase
    {
        [HttpGet("TestGetMethodWithSingleParameterFromRoute/{Id}")] // If I didn't put {Id} the response is 0
        //[Route("[action]/{Id}")]
        //[Route("test/[action]/{Id}")]
        public async Task<IActionResult> GetActionFromRoute([FromRoute] int Id)
        {
            try
            {
                return Ok("The Recived Id Is  " + Id);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An Error has been Detected : {ex.Message}");
            }
        }
        [HttpGet("TestGetMethodWithMultipleParameterFromRoute/{name}/{Id}")]
        public async Task<IActionResult> GetActionFromRoute([FromRoute] int Id, [FromRoute] string? name)
        {
            try
            {
                return Ok("The Recived Id Is " + Id + "and Recived name is " + name);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An Error has been Detected : {ex.Message}");
            }
        }
        [HttpGet("TestGetMethodWithCollecationFromRoute/{ints}")]
        public async Task<IActionResult> GetActionFromRoute([FromRoute] List<int> ints) //invalid 
        {
            try
            {
                return Ok("The Recived list Is with length" + ints.Count);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An Error has been Detected : {ex.Message}");
            }
        }
        [HttpGet("TestGetMethodWithCustomObjectFromRoute/{input}")]
        public async Task<IActionResult> GetActionFromRoute([FromRoute] LoginResponse input)
        {
            try
            {
                return Ok("The Recived list Is with length" + input.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An Error has been Detected : {ex.Message}");
            }
        }
        [HttpGet("TestGetMethodWithMultipleParameterFromHeader")]
        public async Task<IActionResult> GetActionFromHeader([FromHeader] int Id, [FromHeader] string? name)
        {
            try
            {
                return Ok("The Recived Id Is " + Id + "and Recived name is " + name);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An Error has been Detected : {ex.Message}");
            }
        }
    }
}
