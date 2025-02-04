
using System.Net.Mime;
using Microsoft.AspNetCore.Mvc;

[ApiController]
public partial class EmployeesController : ControllerBase
{
    public EmployeesController()
    {

    }

    [HttpPut]
    [Route("/employees/list/{employeeId?}")]
    [SwaggerOptionalRouteParam]
    [ProducesResponseType(201)]
    public IActionResult CreateEmployee(string? employeeId)
    {
        return StatusCode(StatusCodes.Status201Created);
    }
}