using Examples.Charge.Domain.Aggregates.PersonAggregate;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Examples.Charge.Application.Interfaces
{
    public interface IPersonPhoneFacade
    {
        Task<List<PersonPhone>> FindAllAsync();
        Task<bool> InsertPersonPhone(PersonPhone personPhone);
        Task<bool> UpdatePersonPhone(PersonPhone personPhone);
        Task<bool> DeletePersonPhone(string phoneNumber);
    }
}
