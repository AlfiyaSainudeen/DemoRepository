using StudentAPI.Models;

namespace StudentAPI.Repository
{
    public interface IStudentRepository
    {
        void AddStudent(Student student);
        void UpdateStudent(Student student);
        void DeleteStudent(int id);
        Student GetStudent(int id);
       List<Student> GetAllStudent(string std);
        List<Student> GetStudents(string std, string section);
        List<Student> GetAll();
    }
}
