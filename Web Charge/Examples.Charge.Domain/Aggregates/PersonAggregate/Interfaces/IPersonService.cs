using System.Collections.Generic;
using System.Threading.Tasks;

namespace Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces
{
    public interface IPersonService
    {
        Task<List<Person>> FindAllAsync();
        Task<bool> InsertPerson(Person person);
        Task<bool> UpdatePerson(Person person);
        Task<bool> DeletePerson(int businessEntityID);
    }
}
