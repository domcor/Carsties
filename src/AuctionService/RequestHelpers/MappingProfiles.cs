using AuctionService.DTOs;
using AuctionService.Entities;
using AutoMapper;

namespace AuctionService.RequestHelpers
{
    public class MappingProfiles:Profile
    {
        public MappingProfiles() 
        {
            CreateMap<Auction, AuctionDto>().IncludeMembers(x => x.Item);
            CreateMap<Item, AuctionDto>().IncludeMembers();
            CreateMap<CreateAuctionDto, Auction>()
                .ForMember(dest => dest.Item, source => source.MapFrom(s => s));
            CreateMap<CreateAuctionDto, Item>();
        }
    }
}
