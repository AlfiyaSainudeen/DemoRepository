using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentAPI.Models;
using StudentAPI.Repository;

namespace StudentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepository studentRepository;

        public StudentController(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }
        //endpoints
        [HttpPost,Route("GetStudents")]
        public IActionResult GetStudents()
        {
            try
            {
                return Ok(studentRepository.GetAll());

            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpPost,Route("GetStudentById/{id}")]
        public IActionResult GetStudentById(int id)
        {
            try
            {
                return Ok(studentRepository.GetStudent(id));
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpPost,Route("GetStudentByStd/{std}")]
        public IActionResult GetStudentByStd(string std)
        {
            try
            {
                return Ok(studentRepository.GetAllStudent(std));
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpPost,Route("GetStudentByStdOrSession/{std,session}")]
        public IActionResult GetStudentByStdOrSesion(string std,string session)
        {
            try
            {
                return Ok(studentRepository.GetStudents(std, session));

            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpPost,Route("AddStudent")]
        public IActionResult AddStudent(Student student)
        {
            try
            {
                studentRepository.AddStudent(student);
                return Ok(student);
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpPut,Route("EditStudent")]
        public IActionResult Edit(Student student)
        {
            try
            {
                studentRepository.UpdateStudent(student);
                return Ok(student);

            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpDelete,Route("DeleteSudent")]
        public IActionResult Delete(int id)
        {
            try
            {
                studentRepository.DeleteStudent(id);
                return Ok("Student Deleted");

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
