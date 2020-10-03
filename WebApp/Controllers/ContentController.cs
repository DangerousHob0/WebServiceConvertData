using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class ContentController : ControllerBase
    {
        [HttpPost("student/{format?}")]
        [FormatFilter]
        [Produces("application/json", "application/xml")]
        public Student ConvertStudent (Student student)
        {
            return student;
        }
    }
}