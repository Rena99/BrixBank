using System;
using System.ComponentModel.DataAnnotations;
<<<<<<< HEAD

=======
>>>>>>> 07f54aec5ab86da45cd5e641854dc2215ec497f4

namespace Account.Data.Entities
{
    public class Customer
    {
        public Guid CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
    }
}
