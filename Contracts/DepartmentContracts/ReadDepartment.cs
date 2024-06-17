
namespace StudentManagement.Contracts.DepartmentContracts
{
    //response format
    public class ReadDepartment
    {
        public string? DepartmentName { get; set; }

        public int? Staffs { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
