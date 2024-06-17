namespace StudentManagement.Contracts.DepartmentContracts
{
    public class CreateDepartmentResponse
    {
        public string? DepartmentID { get; set; }
        public string? DepartmentName { get; set; }

        public int? Staffs { get; set; }

        public DateTime? Date {  get; set; }    
    }
}
