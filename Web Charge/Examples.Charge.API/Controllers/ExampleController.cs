using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Examples.Charge.Application.Interfaces;
using Examples.Charge.Application.Messages.Request;
using Examples.Charge.Application.Messages.Response;
using System.Threading.Tasks;
using Examples.Charge.Domain.Aggregates.ExampleAggregate;

namespace Examples.Charge.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExampleController : BaseController
    {
        private IExampleFacade _facade;

        public ExampleController(IExampleFacade facade, IMapper mapper)
        {
            _facade = facade;
        }

        [HttpGet]
        public async Task<ActionResult<ExampleListResponse>> Get() => Response(await _facade.FindAllAsync());

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Response(null);
        }

        [HttpPost]
        public IActionResult Post([FromBody] ExampleRequest request)
        {
            return Response(0, null);
        }

        [HttpPost("InsertExample")]
        public async Task<IActionResult> InsertExample(Example example) =>
            Ok(await _facade.InsertExample(example));

        [HttpPut("UpdateExample")]
        public async Task<IActionResult> UpdateExample(Example example) =>
            Ok(await _facade.UpdateExample(example));

        [HttpDelete("DeleteExample/{id}")]
        public async Task<IActionResult> DeleteExample(int id) =>
            Ok(await _facade.DeleteExample(id));
    }
}
