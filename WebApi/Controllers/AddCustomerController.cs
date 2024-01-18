using Domain.Contracts.UseCase.AddCustomer;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models.AddCustomer;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddCustomerController : ControllerBase
    {
        private readonly IAddCustomerUseCase _addCustomerUseCase;

        public AddCustomerController(IAddCustomerUseCase addCustomerUseCase)
        {
            this._addCustomerUseCase = addCustomerUseCase;
        }

        [HttpPost]
        public IActionResult AddCustomer(AddCustomerInput input)
        {
            var customer = new Domain.Entities.Customer(input.name, input.email, input.document);
            _addCustomerUseCase.AddCustomer(customer);
            return Created("", input);
        }
    }


}
