using api_rest.Model;
using api_rest.Business;
using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace api_rest.Controllers
{
    [ApiVersion("1")]
    [ApiController]
    [Route("api/[controller]/v1")]
    public class PersonController : ControllerBase
    {        

        private readonly ILogger<PersonController> _logger;

        private IPersonBusiness _personBusiness;

        public PersonController(ILogger<PersonController> logger, IPersonBusiness personBusiness)
        {
            _logger = logger;
            _personBusiness = personBusiness;
        }

        [HttpGet]
        public IActionResult FindAll() 
        {
            return Ok(_personBusiness.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_personBusiness.FindById(id));
        }

        [HttpPost]
        public IActionResult Post([FromBody]Person person)
        {
            return Ok(_personBusiness.Create(person));
        }

        [HttpPut]
        public IActionResult Put([FromBody] Person person)
        {
            return Ok(_personBusiness.Update(person));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _personBusiness.Delete(id);
            return Ok();
        }

    }
}
