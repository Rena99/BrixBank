using Account.Services.Models;
using System.Threading.Tasks;

namespace Account.Services.Interfaces
{
    public interface INewAccountRepository
    {
        bool AddCustomer(CustomerModel customerModel);
    }
}
