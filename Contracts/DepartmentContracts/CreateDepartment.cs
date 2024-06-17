using System.ComponentModel.DataAnnotations;

namespace StudentManagement.Contracts.DepartmentContracts
{
    //request format
    public class CreateDepartment
    {
       
        public string? DepartmentID { get; set; }
        public string? DepartmentName { get; set; }
        
        public int? Staffs { get; set; }

        
    }
}
