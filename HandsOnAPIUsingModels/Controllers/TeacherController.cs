using HandsOnAPIUsingModels.Models;
using HandsOnAPIUsingModels.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HandsOnAPIUsingModels.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly ITeacherRepository teacherRepository;
        public TeacherController()
        {
            teacherRepository = new TeacherRepository();
        }
        [HttpGet, Route("GetAllTeachers")]

        public IActionResult GetAll()
        {
            try
            {
                List<Teacher> teachers = teacherRepository.GetAll();
                return StatusCode(200, teachers);
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }
        [HttpGet, Route("GetTeacherById/{id}")]

        public IActionResult GetTeacher(int id)
        {
            try
            {
                Teacher teacher = teacherRepository.GetTeacher(id);
                if (teacher != null)
                    return StatusCode(200, teacher);
                else
                    return StatusCode(405);
            }
            catch (Exception ex)
            {
                return StatusCode(501, ex);

            }
        }
        [HttpGet, Route("GetTeacherBySubject/{subject}")]

        public IActionResult GetTeacherBySubject(string subject)
        {
            try
            {
                return StatusCode(200, teacherRepository.GetTeacherBySubject(subject));
            }
            catch (Exception ex)
            {
                return StatusCode(501, ex);
            }
        }
        [HttpPost, Route("AddTeacher")]

        public IActionResult Add(Teacher teacher)
        {
            try
            {
                teacherRepository.Add(teacher);
                return StatusCode(200, teacher);
            }
            catch (Exception ex)
            {
                return StatusCode(501, ex);
            }
        }
        [HttpPut("UpdateTeacher")]
        public IActionResult Update(Teacher teacher)
        {
            try
            {
                teacherRepository.Update(teacher);
                return StatusCode(200, teacher);
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }
        [HttpDelete("Deleteteacher/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                teacherRepository.Delete(id);
                return StatusCode(200, "Teacher deleted");
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }
    }
}
