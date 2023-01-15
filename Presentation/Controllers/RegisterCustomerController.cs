using Domain;
using Domain.Contracts;
using Microsoft.AspNetCore.Mvc;
using Presentation.ViewModels;

namespace Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterCustomerController : ControllerBase
    {
        private readonly IRegisterCustomerBusiness registerCustomerBusiness;

        public RegisterCustomerController(IRegisterCustomerBusiness registerCustomerBusiness)
        {
            this.registerCustomerBusiness = registerCustomerBusiness;
        }

        [HttpPost]
        public bool Post([FromBody] RegisterCustomerViewModel registerCustomerViewModel)
        {
            var customer = new Customer(registerCustomerViewModel.Name, registerCustomerViewModel.Age);
            return this.registerCustomerBusiness.RegisterCustomer(customer);
        }
    }
}
