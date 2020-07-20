
using System;

namespace Account.Services.Interfaces
{
  public interface IAccountInfoServies
    {
        public Guid GetAccount(Guid CustomerId);
    }
}
