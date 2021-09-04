using AutoMapper;

namespace Quotes.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<QuoteDto, Quote>()
                .ForMember(qd => qd.Id, opt => opt.Ignore());

            CreateMap<Quote, QuoteDto>();
        }
    }
}