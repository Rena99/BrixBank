<<<<<<< HEAD
﻿using Account.Data.Entities;
using Account.Services.Models;
using Account.WebApi.DTO;
using AutoMapper;


=======
﻿using Account.Services.Models;
using Account.WebApi.DTO;
using AutoMapper;

>>>>>>> 07f54aec5ab86da45cd5e641854dc2215ec497f4
namespace Account.WebApi.Mappings
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
<<<<<<< HEAD
            CreateMap<CustomerModel, Customer>();
            CreateMap<AccountModel,Data.Entities.Account>();
            CreateMap<Customer,CustomerModel>();
            CreateMap<Data.Entities.Account,AccountModel>();
            CreateMap<CustomerDTO, CustomerModel>();
            ////////
            CreateMap<AccountModel, AccountDTO>()
            .ForMember(d => d.FirstName, a => a.MapFrom(s => s.Customer.FirstName))
              .ForMember(d => d.LastName, a => a.MapFrom(s => s.Customer.LastName));

=======
            CreateMap<CustomerModel, Data.Entities.Customer>();
            CreateMap<CustomerDTO, CustomerModel>();
>>>>>>> 07f54aec5ab86da45cd5e641854dc2215ec497f4
        }
    }
}
