using HandsOnAPIUsingModels1.Models;

namespace HandsOnAPIUsingModels1.Repositories
{
    public interface ITeacherRepository
    {
        void Add(Teacher teacher);
        void Update(Teacher teacher);
        void Delete(int id);
        Teacher GetTeacher(int id);
        List<Teacher> GetAll();
        List<Teacher> GetTeacherBySubject(string subject);
    }
}
