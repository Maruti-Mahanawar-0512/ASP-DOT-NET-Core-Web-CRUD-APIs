using ASP_DOT_NET_Core_Web_APIs.DTO;
using ASP_DOT_NET_Core_Web_APIs.Iservices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASP_DOT_NET_Core_Web_APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthServices _authServices;
        public AuthController(IAuthServices authServices)
        {
            _authServices = authServices;
        }
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody]UserDto usedto)
        {
            try
            {
                var result = await _authServices.LoginUser(usedto);
                if(result.Item1 == 0)
                {
                    return NotFound(result.Item2);
                }
                if (result.Item1 == 1)
                {
                    return BadRequest(result.Item2);
                }
                if (result.Item1 == 2)
                {
                    return Ok(result.Item2);
                }
                return StatusCode(500, result.Item2);

            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
