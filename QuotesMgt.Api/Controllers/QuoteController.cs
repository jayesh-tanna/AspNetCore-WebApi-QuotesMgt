using Microsoft.AspNetCore.Mvc;
using QuotesMgt.Business.Services.Interfaces;
using QuotesMgt.Contracts;

namespace QuotesMgt.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuoteController : ControllerBase
    {
        private readonly IQuoteService _service;

        public QuoteController(IQuoteService service)
        {
            _service = service;
        }

        [Route("list")]
        [HttpGet]
        public IActionResult Get()
        {
            var quotes = _service.List();

            return Ok(quotes);
        }

        [HttpGet]
        [Route("get/{id}")]
        public IActionResult Get(int id)
        {
            var quote = _service.Get(id);

            var author = quote.Author;

            return Ok(quote);
        }


        [HttpPost]
        [Route("create")]
        public IActionResult Create([FromBody]Quote quote)
        {
            _service.Add(quote);

            return CreatedAtAction(nameof(Get), new { id = quote.Id }, quote);
        }
    }
}