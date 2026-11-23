using IE3_Q2_32E3_Ayap_DaimeryGold.DTO.User;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace IE3_Q2_32E3_Ayap_DaimeryGold.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET: api/<ValuesController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { message = "Hello from UserController!" });
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            if (id == 0)
            {
                return Ok(new { message = "Invalid user ID!" });
            }

            if (id < 0)
            {
                return NotFound(new { message = $"User with ID {id} not found!" });
            }

            return Ok(new { message = $"You requested user with ID {id}" });

        }



        // POST api/<ValuesController>
        [HttpPost]
        public IActionResult Post([FromBody] AddUserRequest value)
        {
            return Ok(new { message = "User created successfully!", user = value });
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public ActionResult Pu(int id, [FromBody] EditUserRequest value)
        {
                return Ok(new { message = $"User with ID {id} updated sucessfully!" });
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return NoContent();
        }
    }
}

