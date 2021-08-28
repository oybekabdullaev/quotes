using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Quotes.Controllers
{
    [ApiController]
    [Route("quotes")]
    public class QuotesController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Quote> GetAll()
        {
            return new List<Quote>
            {
                new Quote
                {
                    Id = 1,
                    Author = "Author 1",
                    Body = "Body 1",
                    Category = "Category 1"
                },
                new Quote
                {
                    Id = 2,
                    Author = "Author 2",
                    Body = "Body 2",
                    Category = "Category 2"
                }
            };
        }
    }
}