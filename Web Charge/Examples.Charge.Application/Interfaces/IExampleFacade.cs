
using Examples.Charge.Application.Messages.Response;
using Examples.Charge.Domain.Aggregates.ExampleAggregate;
using System.Threading.Tasks;

namespace Examples.Charge.Application.Interfaces
{
    public interface IExampleFacade
    {
        Task<ExampleListResponse> FindAllAsync();
        Task<bool> InsertExample(Example example);
        Task<bool> UpdateExample(Example example);
        Task<bool> DeleteExample(int id);
    }
}
