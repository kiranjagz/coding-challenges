using Generic.Api.Model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Generic.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ServiceFilter(typeof(ExecutionTimeLogFilter))]
    public class PersonController : ControllerBase
    {
        private static List<Person> _persons = new List<Person>
        {
            new Person { Id = 1, Name = "John Doe", Age = 30 },
            new Person { Id = 2, Name = "Jane Smith", Age = 25 }
        };

        private readonly ILogger<PersonController> _logger;

        public PersonController(ILogger<PersonController> logger)
        {
            _logger = logger;
        }

        // GET: api/<PersonController>
        [HttpGet]
        public IActionResult Get()
        {
            var valueFromRequest = HttpContext.Items["NewKey"] as string;

            _logger.LogInformation($"Value retrived from the request: {valueFromRequest}");

            return Ok(_persons);
        }

        // GET api/<PersonController>/5
        [HttpGet("{id}")]
        public ActionResult<Person> Get(int id)
        {
            var person = _persons.FirstOrDefault(p => p.Id == id);

            if (person == null)
            {
                return NotFound();
            }

            return person;
        }

        // POST api/<PersonController>
        [HttpPost]
        public IActionResult Post([FromBody] Person person)
        {
            if (person == null)
            {
                return BadRequest();
            }

            _persons.Add(person);
            return CreatedAtAction("Post", new { Id = person.Id });

        }

        // PUT api/<PersonController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PersonController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
