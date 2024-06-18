using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentManagement.Contracts.StudentContracts;
using StudentManagement.Data;
using StudentManagement.Models.DepartmentModels;
using StudentManagement.Models.StudentModels;
using StudentManagement.Services;
using System.Security.Cryptography.X509Certificates;

namespace StudentManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {

        private readonly ApplicationContext _database;
        private readonly IStudentService _studentService;
        public StudentController(IStudentService _student, ApplicationContext database)
        {
            _database = database;
            _studentService = _student;
        }

        [HttpPost]
        public IActionResult CreateStudent(StudentRequest request)
        {
            var department = _database.Department.FirstOrDefault(d => d.DepartmentID == request.DepartmentID);
            Student student = new Student { 
                RollNumber = request.RollNumber,
                StudentName = request.StudentName,
                CreateAt = DateTime.UtcNow,
                Department = department,
                            
            
            };
            var response = _studentService.CreateStudent(student);

            var finalResponse = new StudentResponse
            {
                StudentName = response.StudentName,
                CreatedAt = response.CreateAt,
                DepartmentID = response.DepartmentID,
            };


            return Ok(finalResponse);        


        }

        [HttpGet("studentDept/{id}")]
        public async Task<ActionResult<List<Student>>> GetStudentDepartment(string id)
        {

            var department = await (from s in _database.Student where s.RollNumber == id select s).FirstOrDefaultAsync();
            var departmentId = department.DepartmentID;
            var response = _database.Department.FirstOrDefault(d => d.DepartmentID == departmentId);
            //Console.WriteLine(response);
            return Ok(response);

        }
    }
}
