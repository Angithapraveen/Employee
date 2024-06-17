using StudentManagement.Contracts.DepartmentContracts;
using StudentManagement.Models.DepartmentModels;

namespace StudentManagement.Services
{
    public interface IDepartmentService { 
        public Department CreateDepartment(Department department);

        public Department ReadDepartment(string ID);
    
    
    
    }

}
