using Account.Services.Interfaces;
using AutoMapper;
using System;
using System.Configuration;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Account.Data.Repositories
{
   public class LoginRepository:ILoginRepository
    {

        public LoginRepository()
        {
        }
        private readonly AccountContext _context;
        private readonly IMapper _mapper;
        private readonly string salt = "E1F53135E559C253";
        public LoginRepository(IMapper mapper, AccountContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public string ChackUserLogin(string email, string password)
        {
           Entities.Account account = new Entities.Account();
            try
            {
                foreach (var item in _context.Customer)
                {
                    if (item.Email == email && AreEqual(password, item.Password, item.Salt))
                    {
                        var CurrentAccount = _context.Accounts.FirstOrDefault(c => c.CustomerId == item.CustomerId);
                        return CurrentAccount.AccountId.ToString();
                    }
                }
            }
            catch (Exception e)
            {
                return (e.Message);
            }
            return null;
        }

        private bool AreEqual(string plainTextInput, string hashedInput, string salt)
        {
            string newHashedPin = GenerateHash(plainTextInput, salt);
            return newHashedPin.Equals(hashedInput);
        }
        private string GenerateHash(string input, string salt)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(input + salt);
            SHA256Managed sHA256ManagedString = new SHA256Managed();
            byte[] hash = sHA256ManagedString.ComputeHash(bytes);
            return Convert.ToBase64String(hash);
        }
    }
}
