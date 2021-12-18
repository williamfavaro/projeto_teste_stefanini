using Examples.Charge.Domain.Aggregates.ExampleAggregate.Interfaces;
using Examples.Charge.Domain.Aggregates.PersonAggregate;
using Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examples.Charge.Domain.Aggregates.ExampleAggregate
{
    public class ExampleService : IExampleService
    {
        private IExampleRepository _exampleService;
        public ExampleService(IExampleRepository exampleService)
        {
            _exampleService = exampleService;
        }

        public async Task<List<Example>> FindAllAsync() => (await _exampleService.FindAllAsync()).ToList();

        public async Task<bool> InsertExample(Example example) =>
            await _exampleService.InsertExample(example);

        public async Task<bool> UpdateExample(Example example) =>
            await _exampleService.UpdateExample(example);

        public async Task<bool> DeleteExample(int id) =>
            await _exampleService.DeleteExample(id);
    }
}
