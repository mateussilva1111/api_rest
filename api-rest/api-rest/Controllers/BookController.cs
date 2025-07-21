using api_rest.Business;
using api_rest.Data.VO;
using api_rest.Model;
using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace api_rest.Controllers
{
    [ApiVersion("1")]
    [ApiController]
    [Route("api/[controller]/v1")]
    public class BookController : ControllerBase
    {

        private readonly ILogger<BookController> _logger;

        private IBookBusiness _bookBusiness;

        public BookController(ILogger<BookController> logger, IBookBusiness booknBusiness)
        {
            _logger = logger;
            _bookBusiness = booknBusiness;
        }

        [HttpGet]
        public IActionResult FindAll()
        {
            return Ok(_bookBusiness.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_bookBusiness.FindById(id));
        }

        [HttpPost]
        public IActionResult Post([FromBody] BookVO book)
        {
            return Ok(_bookBusiness.Create(book));
        }

        [HttpPut]
        public IActionResult Put([FromBody] BookVO book)
        {
            return Ok(_bookBusiness.Update(book));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _bookBusiness.Delete(id);
            return Ok();
        }

    }
}
