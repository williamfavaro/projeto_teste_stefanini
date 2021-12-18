using Examples.Charge.Application.Interfaces;
using Examples.Charge.Application.Messages.Response;
using Examples.Charge.Domain.Aggregates.PersonAggregate;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Examples.Charge.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : BaseController
    {
        private readonly IPersonFacade _facade;

        public PersonController(IPersonFacade facade)
        {
            _facade = facade;
        }

        [HttpGet]
        public async Task<ActionResult<PersonResponse>> Get() => Response(await _facade.FindAllAsync());

        [HttpPost("InsertPerson")]
        public async Task<IActionResult> InsertPerson(Person person) =>
            Ok(await _facade.InsertPerson(person));

        [HttpPut("UpdatePerson")]
        public async Task<IActionResult> UpdatPerson(Person person) =>
            Ok(await _facade.UpdatePerson(person));

        [HttpDelete("DeletePerson/{id}")]
        public async Task<IActionResult> DeletePerson(int id) =>
            Ok(await _facade.DeletePerson(id));
    }
}
