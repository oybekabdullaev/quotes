using System.Collections.Generic;

namespace Quotes
{
    public static class Storage
    {
        static Storage()
        {
            Quotes = new List<Quote>
            {
                new Quote
                {
                    Id = 1,
                    Author = "Author 1",
                    Body = "Body 1",
                    QuoteCategory = QuoteCategory.Funny
                },
                new Quote
                {
                    Id = 2,
                    Author = "Author 2",
                    Body = "Body 2",
                    QuoteCategory = QuoteCategory.Motivational
                },
                new Quote
                {
                    Id = 3,
                    Author = "Author 3",
                    Body = "Body 3",
                    QuoteCategory = QuoteCategory.Funny
                }
            };
        }
        
        public static IList<Quote> Quotes { get; }
    }
}