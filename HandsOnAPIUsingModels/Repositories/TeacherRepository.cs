using HandsOnAPIUsingModels.Models;

namespace HandsOnAPIUsingModels.Repositories
{
    public class TeacherRepository : ITeacherRepository
    {
        public static List<Teacher> teachers = new List<Teacher>();
        public void Add(Teacher teacher)
        {
            try
            {
                teachers.Add(teacher);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Delete(int id)
        {
            try
            {
                foreach (var teacher in teachers)
                {
                    if (teacher.Id == id)
                    {
                        teachers.Remove(teacher);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Teacher> GetAll()
        {
            return teachers;
        }

        public Teacher GetTeacher(int id)
        {
            try
            {
                foreach (var teacher in teachers)
                {
                    if (teacher.Id == id)
                    {
                        return teacher;
                    }
                }
                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Teacher> GetTeacherBySubject(string subject)
        {
            List<Teacher> tchr = new List<Teacher>();
            try
            {
                foreach (var teacher in teachers)
                {
                    if (teacher.Subject == subject)
                    {
                        tchr.Add(teacher);
                    }
                }
                return tchr;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Update(Teacher teacher)
        {
            try
            {
                foreach (var item in teachers)
                {
                    if (item.Id == teacher.Id)
                    {
                        item.Name = teacher.Name;
                        item.Subject = teacher.Subject;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }

}
