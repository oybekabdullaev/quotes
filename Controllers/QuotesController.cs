using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace Quotes.Controllers
{
    [ApiController]
    [Route("api/quotes")]
    public class QuotesController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Quote> GetAll()
        {
            return Storage.Quotes.ToArray();
        }

        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            var quote = Storage.Quotes.SingleOrDefault(q => q.Id == id);

            if (quote == null)
                return NotFound();

            return Ok(quote);
        }
        
        [HttpGet("categories/{category}")]
        public IEnumerable<Quote> GetByCategory(QuoteCategory category)
        {
            return Storage.Quotes.Where(q => q.QuoteCategory == category).ToArray();
        }
        
        [HttpGet("random")]
        public Quote GetRandom()
        {
            var index = new Random().Next(0, Storage.Quotes.Count);
            return Storage.Quotes[index];
        }

        [HttpPut("{id:int}")]
        public IActionResult Edit(int id, [FromBody] Quote newQuote)
        {
            var oldQuote = Storage.Quotes.SingleOrDefault(q => q.Id == id);

            if (oldQuote == null)
                return NotFound();

            oldQuote.Author = newQuote.Author;
            oldQuote.Body = newQuote.Body;
            oldQuote.QuoteCategory = newQuote.QuoteCategory;

            return Ok(oldQuote);
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            var quote = Storage.Quotes.SingleOrDefault(q => q.Id == id);

            if (quote == null)
                return NotFound();

            Storage.Quotes.Remove(quote);

            return Ok(quote);
        }
    }
}