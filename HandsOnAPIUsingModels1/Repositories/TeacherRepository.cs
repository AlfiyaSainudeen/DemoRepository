using HandsOnAPIUsingModels1.Models;

namespace HandsOnAPIUsingModels1.Repositories
{
    public interface TeacherRepository:ITeacherRepository
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
				foreach(var item in teachers)
				{
					if(item.Id==id)
					{
						teachers.Remove(item);
					}
				}
			}
			catch (Exception)
			{

				throw;
			}
        }
		public List<Teacher>GetAll()
		{
			try
			{
				return teachers;

			}
			catch (Exception)
			{

				throw;
			}
		}
		public Teacher GetTeacher(int id)
		{
			try
			{
				foreach(var teacher in teachers)
				{
					if (teacher.Id == id)
						return teacher;
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
			try
			{
				List<Teacher> teacherswithSubject = new List<Teacher>();
				foreach(var teacher in teachers)
				{
					if (teacher.Subject == subject)
						teacherswithSubject.Add(teacher);
				}
				return teacherswithSubject;

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
				foreach(var item in teachers)
				{
					if(item.Id==teacher.Id)
					{
						item.Subject = teacher.Subject;
						item.Name = teacher.Name;
						item.Stds = teacher.Stds;
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
