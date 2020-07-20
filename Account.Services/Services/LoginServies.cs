using Account.Services.Interfaces;
using System;


namespace Account.Services.Services
{
    public class LoginServies : ILoginServies
    {
        private readonly ILoginRepository loginRepository;
        public LoginServies(ILoginRepository loginRepository)
        {
            this.loginRepository = loginRepository;
        }
        public string ChackUserLogin(string email, string password)
        {
          return loginRepository.ChackUserLogin(email, password);
        }
    }
}
