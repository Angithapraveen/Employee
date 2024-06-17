using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentManagement.Contracts.DepartmentContracts;
using StudentManagement.Models.DepartmentModels;
using StudentManagement.Services;

namespace StudentManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentService _service;

        public DepartmentController(IDepartmentService service) {

            _service = service;
        
        }
        
        [HttpPost("/department")]
        public IActionResult Department(CreateDepartment request) {
            //getting data based on CreateDepartment Contract

            //convert to internal model language
            var department = new Department(
                    request.DepartmentID,
                    request.DepartmentName,
                    request.Staffs,
                    DateTime.UtcNow

                );

            /*
                using setters
                var department = new Department{
                    DepartmentID = request.DepartmentID
                    ....
                    ....
                }
             
             
             */

            //call services

            Department response = _service.CreateDepartment(department);




            //reformat data returned from services 
            CreateDepartmentResponse finalResponse = new CreateDepartmentResponse { 
                DepartmentID = response.DepartmentID,
                DepartmentName = response.DepartmentName,
                Staffs = response.Staffs,
                Date = response.CreatedAt
            
            
            };


            //return data from end-point
            return Ok(finalResponse);
        
        
        }

        [HttpGet("/department/{id}")]

        public IActionResult GetDepartment(string id) 
        {
            //sending response based on ReadDepartment Contract
            Department response = _service.ReadDepartment(id);

            ReadDepartment finalResponse = new ReadDepartment {
                DepartmentName = response.DepartmentName,
                Staffs = response.Staffs,
                CreatedDate = response.CreatedAt
            };

            return Ok(finalResponse);


        }
    }
}
