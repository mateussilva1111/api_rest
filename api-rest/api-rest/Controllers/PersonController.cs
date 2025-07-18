using api_rest.Model;
using api_rest.Service;
using Microsoft.AspNetCore.Mvc;

namespace api_rest.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {        

        private readonly ILogger<PersonController> _logger;

        private IPersonService _personService;

        public PersonController(ILogger<PersonController> logger, IPersonService personService)
        {
            _logger = logger;
            _personService = personService;
        }

        [HttpGet]
        public IActionResult FindAll() 
        {
            return Ok(_personService.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_personService.FindById(id));
        }

        [HttpPost]
        public IActionResult Post([FromBody]Person person)
        {
            return Ok(_personService.Create(person));
        }

        [HttpPut]
        public IActionResult Put([FromBody] Person person)
        {
            return Ok(_personService.Update(person));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _personService.Delete(id);
            return Ok();
        }

    }
}
