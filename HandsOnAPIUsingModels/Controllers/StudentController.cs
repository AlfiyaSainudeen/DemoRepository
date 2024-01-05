using HandsOnAPIUsingModels.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HandsOnAPIUsingModels.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        static List<Student> students = new List<Student>() //add static to change the list
        {
            new Student{Id=123,Name="Alfiya",Age=20,Std="4"},
             new Student{Id=124,Name="Alfi",Age=21,Std="5"}
        };
        //defin action methods or end points
        //Add new Student
        //[HttpPost("AddStudent")] use this method or otherwise under step
        [HttpPost, Route("AddStudent")]
        public Student Add(Student student)//pass the student details through the request body
        {
            students.Add(student);
            return student;
        }
        [HttpGet, Route("GetAll")]
        public List<Student> GetStudents()//get all students using array of students
        {
            return students;
        }
        [HttpGet, Route("GetStudentById/{id}")]
        public Student GetStudentById(int id)
        {
            foreach (var item in students)
            {
                if (item.Id == id)
                    return item;
            }
            return null;
        }
        [HttpGet, Route("GetStudentByName/{name}")]

        public Student GetStudentByName(string name)
        {
            foreach (var item in students)
            {
                if (item.Name == name)
                    return item;
            }
            return null;
        }

        [HttpDelete, Route("DeleteStudent/{id}")]
        public string Delete(int id)
        {
            try
            {
                Student student = null;
                foreach (var item in students)
                {
                    if (item.Id == id)
                    {
                        student = item;
                        break;
                    }
                }
                //remove student
                if (student == null)
                {
                    students.Remove(student);
                    return "Student Deleted";

                }
                else
                {
                    return "invalid deleted";
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpGet, Route("GetStudentByNameAndAge/{Age},{Name}")]
        public Student GetStudentByNameAndAge(string Name,int Age)
        {
            foreach (var item in students)
            {
                if (item.Name == Name || )
                    return item;
            }
            return null;

        }

    }
}
