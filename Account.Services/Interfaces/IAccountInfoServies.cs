
using Account.Services.Models;
using System;

namespace Account.Services.Interfaces
{
  public interface IAccountInfoServies
    {
        public AccountModel GetAccount(Guid CustomerId);
    }
}
