using Microsoft.AspNetCore.Mvc;
[Route("customer")]
    public class CustomerCareController : Controller
    {
        public IActionResult Index()
        {
        return Ok("This is the index of the CustomerCareController");
        }

        [Route("fileclaim")]
        public IActionResult NewClaim()
        {
            return Ok("NewClaim");
        }

        [Route("ClaimStatus")]
        public IActionResult ClaimHistory()
        {
            return Ok("My Claims");
        }
        
    }
