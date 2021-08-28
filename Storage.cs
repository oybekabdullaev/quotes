using System.Collections.Generic;

namespace Quotes
{
    public static class Storage
    {
        public static IEnumerable<Quote> Quotes => new List<Quote>
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
            },
            new Quote
            {
                Id = 3,
                Author = "Author 3",
                Body = "Body 3",
                Category = "Category 3"
            }
        };
    }
}