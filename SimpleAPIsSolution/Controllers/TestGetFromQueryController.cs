using CRUD_Operation_API.DTO_s;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace CRUD_Operation_API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class TestGetFromQueryController : ControllerBase
    {
        //Get ALL Data From Specific Source 
        //Get Data Without Dynamic Fillteration (-/most case)
        [HttpGet]
        [Route("TestGetMethod")]
        public async Task<IActionResult> GetAction()
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An Error has been Detected : {ex.Message}");
            }
        }
        //Get One 
        //Check If Exisit 
        [HttpGet]
        [Route("TestGetMethodWithSingleParameter")]
        public async Task<IActionResult> GetAction(int Id)
        {
            try
            {
                return Ok($"The Recived Id Is {Id}");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An Error has been Detected : {ex.Message}");
            }
        }
        //Serach --> Get One - Get All - Check Exisit 
        [HttpGet("TestGetMethodWithMultipleParameter")]
        public async Task<IActionResult> GetAction(int id, string name)
        {
            try
            {
                return Ok($"The ID: {id}\nThe Name: {name}");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Ann Error Has Occured: {ex.Message}");
            }
        }
        //Collection
        [HttpGet("TestGetMethodWithCollecation")]
        public async Task<IActionResult> GetAction([FromQuery] List<int> ints) //not recommended 
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
        [HttpGet("TestGetMethodWithCustomObject")]
        public async Task<IActionResult> GetAction([FromQuery] LoginResponse input) // I will create DTO Folder -> LoginResponse.cs
        {
            try
            {
                return Ok(input.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An Error has been Detected : {ex.Message}");
            }
        }
    }
}
