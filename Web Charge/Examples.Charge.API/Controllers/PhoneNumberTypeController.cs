using Examples.Charge.Application.Interfaces;
using Examples.Charge.Domain.Aggregates.PersonAggregate;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Examples.Charge.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhoneNumberTypeController : BaseController
    {
        private readonly IPhoneNumberTypeFacade _facade;

        public PhoneNumberTypeController(IPhoneNumberTypeFacade facade)
        {
            _facade = facade;
        }

        [HttpGet]
        public async Task<IActionResult> Get() =>
            Ok(await _facade.FindAllAsync());

        [HttpPost("InsertPhoneNumberType")]
        public async Task<IActionResult> InsertPhoneNumberType(PhoneNumberType phoneNumberType) =>
            Ok(await _facade.InsertPhoneNumberType(phoneNumberType));

        [HttpPut("UpdatePhoneNumberType")]
        public async Task<IActionResult> UpdatePhoneNumberType(PhoneNumberType phoneNumberType) =>
            Ok(await _facade.UpdatePhoneNumberType(phoneNumberType));

        [HttpDelete("DeletePhoneNumberType/{id}")]
        public async Task<IActionResult> DeletePhoneNumberType(int id) =>
            Ok(await _facade.DeletePhoneNumberType(id));
    }
}
