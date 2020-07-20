using System;
using System.Collections.Generic;
using System.Text;

namespace Account.Services.Models
{
   public class AccountModel
    {

        public DateTime OpenDate { get; set; }
        public double Balance { get; set; }
        public Guid CustomerId { get; set; }
        public CustomerModel Customer { get; set; }
    }
}
