using AutoMapper;
using OnlineEdu.DTO.DTOs.SubscriberDtos;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Mapping
{
    public class SubscriberMapping : Profile
    {
        public SubscriberMapping()
        {
            CreateMap<CreateSubscriberDtos, Subscriber>().ReverseMap();
            CreateMap<UpdateSubscriberDtos, Subscriber>().ReverseMap();
        }
    }
}
