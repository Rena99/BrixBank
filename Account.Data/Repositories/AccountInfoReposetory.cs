

using Account.Services.Interfaces;
using Account.Services.Models;
using AutoMapper;
using System;
using System.Linq;

namespace Account.Data.Repositories
{
    public class AccountInfoReposetory : IAccountInfoReposetory
    {
        private readonly AccountContext context;
        private readonly IMapper mapper;
       public AccountInfoReposetory(AccountContext context, IMapper mapper)
        {
            this.mapper = mapper;
            this.context = context;
        }
        public Guid GetAccount(Guid CustomerId)
        {
            var UserAccuont = context.Accounts.FirstOrDefault(a => a.Customer.CustomerId == CustomerId);
            AccountModel UserModel = mapper.Map<AccountModel>(UserAccuont);
            return UserModel.CustomerId;
        }

   
    }
}
