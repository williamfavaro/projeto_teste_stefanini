using System.Collections.Generic;
using System.Threading.Tasks;

namespace Examples.Charge.Domain.Aggregates.ExampleAggregate.Interfaces
{
    public interface IExampleService
    {
        Task<List<Example>> FindAllAsync();
        Task<bool> InsertExample(Example example);
        Task<bool> UpdateExample(Example example);
        Task<bool> DeleteExample(int id);
    }
}
