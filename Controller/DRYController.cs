using Microsoft.AspNetCore.Mvc;

namespace CleanCodeApi.Controllers
{
    /// DRYController demonstrates the DRY (Don't Repeat Yourself) principle.
    /// DRY means avoiding repetitive code by abstracting common logic into a reusable method,
    /// so if changes are needed, you update only one location.
    [ApiController]
    [Route("api/[controller]")]
    public class DRYController : ControllerBase
    {
        /// demonstrating the DRY principle by eliminating code repetition between endpoints.
        private IActionResult CreateErrorResponse(string errorMessage)
        {
            // This is the reusable part: if our error response format needs to change,
            return BadRequest(new { Error = errorMessage });
        }

        /// GET: /api/dry/greeting
        [HttpGet("greeting")]
        public IActionResult GetGreeting()
        {
            bool isGreetingAvailable = false;
            if (!isGreetingAvailable)
            {
                return CreateErrorResponse("Greeting is not available at the moment.");
            }

            return Ok("Hello, world!");
        }

        /// GET: /api/dry/farewell
        [HttpGet("farewell")]
        public IActionResult GetFarewell()
        {
            bool isFarewellAvailable = false;
            if (!isFarewellAvailable)
            {
                return CreateErrorResponse("Farewell is not available right now.");
            }

            return Ok("Goodbye, world!");
        }
    }
}
