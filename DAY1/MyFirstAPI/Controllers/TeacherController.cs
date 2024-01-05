using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;//base library

namespace MyFirstAPI.Controllers
{
    [Route("api/[controller]")]//route specifies url patterns of a controller
    [ApiController]//attribute
    public class TeacherController : ControllerBase
    {
        //action method
        [HttpGet("Greet")]//this method is invoked by get request
        //request  http://localhost:28575/api/Teacher
        // Teacher is the controller Name
        public string Greet()
        {
            return "Good Morning Teachers";//sent this msg as a http response message
        }
        [HttpGet("GetAll")]
        public string[] GetTeachers()
        {
            return new string[] { "Alfiya", "Ajin", "Anzal" };
        }
        [HttpGet]
        public string Hello()
        {
            return "hello world!";
        }
        [HttpGet("GetTeacherByStd/{std}")]//route with parameter
        //http://localhost:28575/api/Teacher/GetTeacherByStd/2
        public string[] GetTeacherByClass(string std)
        {
            return new string[] { "Alfiya", "Ajin", "Anzal" ,"Joseph","Tobince"};
        }
    }
}
