using System.Collections.Generic;
using System.Linq;
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
            return Storage.Quotes.ToArray();
        }
    }
}