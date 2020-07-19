using Account.Services.Models;
using System.Threading.Tasks;

namespace Account.Services.Interfaces
{
    public interface INewAccountService
    {
        bool AddCustomer(CustomerModel customerModel);
    }
}
