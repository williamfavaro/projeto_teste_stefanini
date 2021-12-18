using AutoMapper;
using Examples.Charge.Application.Dtos;
using Examples.Charge.Application.Interfaces;
using Examples.Charge.Application.Messages.Response;
using Examples.Charge.Domain.Aggregates.ExampleAggregate;
using Examples.Charge.Domain.Aggregates.ExampleAggregate.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examples.Charge.Application.Facade
{
    public class ExampleFacade : IExampleFacade
    {
        private IExampleService _exampleService;
        private IMapper _mapper;

        public ExampleFacade(IExampleService exampleService, IMapper mapper)
        {
            _exampleService = exampleService;
            _mapper = mapper;
        }

        public async Task<ExampleListResponse> FindAllAsync()
        {
            var result = await _exampleService.FindAllAsync();
            var response = new ExampleListResponse();
            response.ExampleObjects = new List<ExampleDto>();
            response.ExampleObjects.AddRange(result.Select(x => _mapper.Map<ExampleDto>(x)));
            return response;
        }

        public async Task<bool> InsertExample(Example example) =>
            await _exampleService.InsertExample(example);

        public async Task<bool> UpdateExample(Example example) =>
            await _exampleService.UpdateExample(example);

        public async Task<bool> DeleteExample(int id) =>
            await _exampleService.DeleteExample(id);
    }
}
