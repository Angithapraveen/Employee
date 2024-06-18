using StudentManagement.Data;
using StudentManagement.Models.StudentModels;

namespace StudentManagement.Services
{
    public class StudentServices : IStudentService
    {

        private readonly ApplicationContext _database;

        public StudentServices(ApplicationContext database)
        {
            _database = database;
        }

        public Student CreateStudent(Student student) {

            _database.Student.Add(student);
            _database.SaveChanges();
            return student;
        }
       
    }
}
