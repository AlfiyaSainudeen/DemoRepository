using StudentAPI.Models;

namespace StudentAPI.Repository
{
    public class StudentRepository : IStudentRepository
    {
        public List<Student> students = new List<Student>();
        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void DeleteStudent(int id)
        {

            Student student = students.SingleOrDefault(s => s.Id == id);
            students.Remove(student);
        }

        public List<Student> GetAll()
        {
            return students;
        }

        public Student GetStudent(int id)
        {
            return students.SingleOrDefault(s => s.Id==id);
        }

        public List<Student> GetStudents(string std, string section)
        {
            return students.Where(s => s.Std == std&&s.Section==section).ToList();
        }

        public void UpdateStudent(Student student)
        {
           foreach(var s in students)
            {
                if(s.Id==student.Id)
                {
                    s.Std = student.Std;
                    s.Section = student.Section;
                    s.Name = student.Name;
                }
            }
        }

       

        List<Student> IStudentRepository.GetAllStudent(string std)
        {
            return students.Where(s => s.Std == std).ToList();
        }
    }
}
