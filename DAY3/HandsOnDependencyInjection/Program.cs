namespace HandsOnDependencyInjection
{
    internal class Program
    {
        class Student
        {
            public int Id;
            public string Name;

            public Student(int id,string name)
            {
                Id = id;
                Name = name;
            }
        }
        class Register
        {
            Student student;
           // public Register()
           // {
              //  student = new Student();
            //}
            public Register(Student student)//here student object is created with out its values/dependencies
            {
                this.student = student;
            }
            public void Details()
            {
                Console.WriteLine($"Id:{student.Id} Name:{student.Name}");
            }
        }
        class School
        {
            public readonly Register register;
            public School(Register register)
            {
                this.register = register;
            }
        }
        static void Main(string[] args)
        {
            Register obj = new Register(new Student(12,"abi"));
            obj.Details();
        }
    }
}
