using Microsoft.AspNetCore.Mvc;
using AlphabetCheckAPI.Prop;
using AlphabetCheckAPI.Compute;

namespace AlphabetCheckAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlphabetCheckAPIController : ControllerBase
    {
        public AlphabetCheckAPIController()
        {
        }

        [HttpPost]
        public IActionResult CheckIfContainsAllAlphabets([FromBody] AlphabetCheckRequest request)
        {
            if(string.IsNullOrEmpty(request.Input))
            {
                return BadRequest("Input string can not be empty or null.");
            }
            AlphabetCheckCompute obj = new AlphabetCheckCompute();
            bool containsAllAlphabets = obj.ContainsAllAlphabets(request.Input);

            return Ok(new AlphabetCheckResponse
            {
                Input = request.Input,
                ContainsAllAlphabets = containsAllAlphabets
            });
        }
    }
}
