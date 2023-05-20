using Microsoft.AspNetCore.Mvc;

namespace InAndOut.Controllers
{
    public class AppointmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [Route("Main/{id1}/{id2}")]
        public IActionResult Details(int id1, int id2)
        {
            return Ok("el id es:" + id1 + " " + id2);
        }
    }
}
