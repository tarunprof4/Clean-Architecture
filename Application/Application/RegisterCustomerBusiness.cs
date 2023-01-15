using Domain;
using Domain.Contracts;

namespace Application
{
    public class RegisterCustomerBusiness : IRegisterCustomerBusiness
    {
        private readonly IRegisterCustomerRepository registerCustomerRepository;
        public RegisterCustomerBusiness(IRegisterCustomerRepository registerCustomerRepository)
        {
            this.registerCustomerRepository = registerCustomerRepository;
        }
        public bool RegisterCustomer(Customer customer)
        {
            if (customer.CanCustomerRegister())
            {
                return this.registerCustomerRepository.RegisterCustomer(customer);
            }
            return false;
        }
    }
}
