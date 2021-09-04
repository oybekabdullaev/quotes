using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace Quotes.Controllers
{
    [ApiController]
    [Route("api/quotes")]
    public class QuotesController : ControllerBase
    {
        private readonly IMapper _mapper;

        public QuotesController(IMapper mapper)
        {
            _mapper = mapper;
        }
        
        [HttpGet]
        public IEnumerable<QuoteDto> GetAll()
        {
            return _mapper.Map<QuoteDto[]>(Storage.Quotes.ToArray());
        }

        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            var quote = Storage.Quotes.SingleOrDefault(q => q.Id == id);

            if (quote == null)
                return NotFound();

            return Ok(_mapper.Map<QuoteDto>(quote));
        }
        
        [HttpGet("categories/{category}")]
        public IEnumerable<QuoteDto> GetByCategory(QuoteCategory category)
        {
            return _mapper.Map<QuoteDto[]>(Storage.Quotes.Where(q => q.QuoteCategory == category).ToArray());
        }
        
        [HttpGet("random")]
        public QuoteDto GetRandom()
        {
            var index = new Random().Next(0, Storage.Quotes.Count);
            return _mapper.Map<QuoteDto>(Storage.Quotes[index]);
        }

        [HttpPut("{id:int}")]
        public IActionResult Edit(int id, [FromBody] QuoteDto newQuote)
        {
            var oldQuote = Storage.Quotes.SingleOrDefault(q => q.Id == id);

            if (oldQuote == null)
                return NotFound();

            _mapper.Map(newQuote, oldQuote);

            return Ok(_mapper.Map<QuoteDto>(oldQuote));
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            var quote = Storage.Quotes.SingleOrDefault(q => q.Id == id);

            if (quote == null)
                return NotFound();

            Storage.Quotes.Remove(quote);

            return Ok(_mapper.Map<QuoteDto>(quote));
        }
    }
}