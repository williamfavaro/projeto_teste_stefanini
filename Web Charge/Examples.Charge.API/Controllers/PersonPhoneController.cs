using Examples.Charge.Application.Interfaces;
using Examples.Charge.Domain.Aggregates.PersonAggregate;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Examples.Charge.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonPhoneController : BaseController
    {
        private readonly IPersonPhoneFacade _facade;

        public PersonPhoneController(IPersonPhoneFacade facade)
        {
            _facade = facade;
        }

        [HttpGet]
        public async Task<IActionResult> Get() =>
            Ok(await _facade.FindAllAsync());

        [HttpPost("InsertPersonPhone")]
        public async Task<IActionResult> InsertPersonPhone(PersonPhone personPhone) =>
            Ok(await _facade.InsertPersonPhone(personPhone));

        [HttpPut("UpdatePersonPhone")]
        public async Task<IActionResult> UpdatePersonPhone(PersonPhone personPhone) =>
            Ok(await _facade.UpdatePersonPhone(personPhone));

        [HttpDelete("DeletePersonPhone/{phoneNumber}")]
        public async Task<IActionResult> DeletePersonPhone(string phoneNumber) =>
            Ok(await (_facade.DeletePersonPhone(phoneNumber)));
    }
}
