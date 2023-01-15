using Domain;
using Domain.Contracts;

namespace Repository
{
    public class RegisterCustomerRepository : IRegisterCustomerRepository
    {
        public bool RegisterCustomer(Customer customer)
        {
            return true;
        }
    }
}
