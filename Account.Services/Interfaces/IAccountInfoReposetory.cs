using Account.Services.Models;
using System;

namespace Account.Services.Interfaces
{
   public interface IAccountInfoReposetory
    {
        public Guid GetAccount(Guid CustomerId);
    }
}
