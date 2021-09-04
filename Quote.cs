namespace Quotes
{
    public class Quote
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string Body { get; set; }
        public QuoteCategory QuoteCategory { get; set; }
    }
}