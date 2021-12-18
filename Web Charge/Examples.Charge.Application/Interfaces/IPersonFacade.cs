using Examples.Charge.Application.Messages.Response;
using Examples.Charge.Domain.Aggregates.PersonAggregate;
using System.Threading.Tasks;

namespace Examples.Charge.Application.Interfaces
{
    public interface IPersonFacade
    {
        Task<PersonResponse> FindAllAsync();
        Task<bool> InsertPerson(Person person);
        Task<bool> UpdatePerson(Person person);
        Task<bool> DeletePerson(int businessEntityID);
    }
}