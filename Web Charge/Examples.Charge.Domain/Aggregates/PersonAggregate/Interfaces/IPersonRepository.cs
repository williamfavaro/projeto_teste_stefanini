using System.Collections.Generic;
using System.Threading.Tasks;

namespace Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces
{
    public interface IPersonRepository
    {
        Task<IEnumerable<Person>> FindAllAsync();
        Task<bool> InsertPerson(Person person);
        Task<bool> UpdatePerson(Person person);
        Task<bool> DeletePerson(int businessEntityID);
    }
}
