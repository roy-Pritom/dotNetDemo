using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dotNetDemo.API.Controllers
{
    [Route("api/values")]
    [ApiController]
    public class ValueController1 : ControllerBase
    {

        [HttpGet]
        public string GetName()
        {
            return "Pritom Roy";
        }

        [HttpGet]
        [Route("fullname")]
        // [Route("[action]")]

        public string GetFullName()
        {
            return "Full name";
        }
    }
}
