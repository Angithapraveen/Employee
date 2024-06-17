using StudentManagement.Contracts.DepartmentContracts;
using StudentManagement.Data;
using StudentManagement.Models.DepartmentModels;

namespace StudentManagement.Services
{
    //implementing IDepartment Interface
    public class DepartmentService : IDepartmentService
    {
        private readonly ApplicationContext _database;
        public DepartmentService(ApplicationContext database) {

            _database = database;
        }
        public Department CreateDepartment(Department department)
        {
            _database.Department.Add(department);
            _database.SaveChanges();

            return department;
        }

        public Department ReadDepartment(string ID) {

            return _database.Department.Find(ID);
       
        
        }
    }
}
