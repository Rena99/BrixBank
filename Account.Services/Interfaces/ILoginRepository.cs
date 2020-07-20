

namespace Account.Services.Interfaces
{
   public interface ILoginRepository
    {
        public string ChackUserLogin(string email, string password);
    }
}
