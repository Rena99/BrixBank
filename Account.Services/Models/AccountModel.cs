using System;
<<<<<<< HEAD
using System.Collections.Generic;
using System.Text;

namespace Account.Services.Models
{
   public class AccountModel
    {

=======

namespace Account.Services.Models
{
    public class AccountModel
    {
>>>>>>> 07f54aec5ab86da45cd5e641854dc2215ec497f4
        public DateTime OpenDate { get; set; }
        public double Balance { get; set; }
        public Guid CustomerId { get; set; }
        public CustomerModel Customer { get; set; }
    }
}
