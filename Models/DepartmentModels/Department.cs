using StudentManagement.Models.StudentModels;
using System.ComponentModel.DataAnnotations;

namespace StudentManagement.Models.DepartmentModels
{
    public class Department
    {
        [Key]
        public string DepartmentID { get; set; }

        public string DepartmentName { get; set; }
        public int? Staffs { get; set; }
        public DateTime? CreatedAt { get; set; }

        public ICollection<Student> Students { get; set; }



        public Department(string? departmentID, string? departmentName, int? staffs, DateTime? createdAt)
        {
            DepartmentID = departmentID;
            DepartmentName = departmentName;
            Staffs = staffs;
            CreatedAt = createdAt;
        }
    }
}
