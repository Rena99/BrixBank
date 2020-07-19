using Account.Services.Models;
using Account.WebApi.DTO;
using AutoMapper;

namespace Account.WebApi.Mappings
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<CustomerModel, Data.Entities.Customer>();
            CreateMap<CustomerDTO, CustomerModel>();
        }
    }
}
