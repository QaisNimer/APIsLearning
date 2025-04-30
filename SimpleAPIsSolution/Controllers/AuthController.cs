using CRUD_Operation_API.DTO_s;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace CRUD_Operation_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        [HttpPost("[action]")]
        public async Task<IActionResult> LoginWithMultiParams(string name, string password) {
            try
            {
                if (string.IsNullOrWhiteSpace(name)&& string.IsNullOrWhiteSpace(password)
                    || !name.Equals("Qais") || !password.Equals("qaiz@123455"))
                {
                    return StatusCode(400,"Invalid Username / Password");
                }
                return Ok("Login Success");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An Error Was Occured: {ex.Message}");
            }
        }

            [HttpPost("[action]")]
            public async Task<IActionResult> LoginWitCustomObj(LoginInput input)
            {
                try
                {
                    if (string.IsNullOrWhiteSpace(input.Name) || string.IsNullOrWhiteSpace(input.Password) 
                        || !input.Name.Equals("Qais") || !input.Password.Equals("qaiz@123455"))
                    {
                        return StatusCode(400, "Invalid Username / Password");
                    }
                    return Ok("Login Success");
                }
                catch (Exception ex)
                {
                    return StatusCode(500, $"An Error Was Occured: {ex.Message}");
                }
            }

            [HttpPost("[action]")]
        public async Task<IActionResult> SignUp()
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
        public async Task<IActionResult> ResetPassword()
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
        [HttpPost("[action]")]
        public async Task<IActionResult> SendOTP()
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
