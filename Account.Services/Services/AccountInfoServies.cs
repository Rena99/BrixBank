

using Account.Services.Interfaces;
using Account.Services.Models;
using System;

namespace Account.Services.Services
{
    public class AccountInfoServies : IAccountInfoServies
    {

        private readonly IAccountInfoReposetory accountInfoReposetory;
        public AccountInfoServies(IAccountInfoReposetory accountInfoReposetory)
        {
            this.accountInfoReposetory = accountInfoReposetory;
        }
     
        public Guid GetAccount(Guid CustomerId)
        {
            return accountInfoReposetory.GetAccount(CustomerId);
        }
    }
}
