using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet ("hello")]
        public ActionResult<string> HelloApi (string name)
        {
            if(string.IsNullOrWhiteSpace(name))
            { 
                return StatusCode(4555, "lusine");
             
            }
            return "hello " + name;
        }

        [HttpGet("authorization")]
        public ActionResult<bool> Authorization(AuthorizationRequst requst)
        {
            if (requst.login == "admin" && requst.password == "123")
                return false;
            else return true;
        }
    }

    public class AuthorizationRequst
    {
        public string login { get; set; }   
        public string password { get; set; }
    }
}
