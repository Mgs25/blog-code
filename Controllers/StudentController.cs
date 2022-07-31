using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Implementation.Controllers;

[ApiController]
[Authorize]
[Route("[controller]")]
public class StudentController : ControllerBase
{
    private static readonly Student[] StudentNames = new[]
    {
        new Student() {
            Name = "Methran",
            Age = 19,
            Gender = Gender.Male
        },
        new Student() {
            Name = "Sridhar",
            Age = 22,
            Gender = Gender.Male
        },
        new Student() {
            Name = "Pownraj",
            Age = 19,
            Gender = Gender.Male
        }
    };

    private readonly ILogger<StudentController> _logger;

    public StudentController(ILogger<StudentController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<Student> Get()
    {
        return StudentNames.ToArray();
    }
}
