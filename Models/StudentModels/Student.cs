using StudentManagement.Models.DepartmentModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentManagement.Models.StudentModels
{
    public class Student
    {
        [Key]
        public string? RollNumber { get; set; }

        public string? StudentName { get; set; }

        public DateTime? CreateAt { get; set; }

        [ForeignKey("Department")]  
        public string? DepartmentID { get; set; } // Foreign key

        public Department? Department { get; set; }

        
       
    }

}
