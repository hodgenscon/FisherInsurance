using Microsoft.AspNetCore.Mvc;
    public class PageController : Controller
    {
        public IActionResult Index()
        {
        return Ok("This is the index of the PageController");
        }
        public IActionResult Quote()
        {
            return Ok("Page Quote");
        }
    }
