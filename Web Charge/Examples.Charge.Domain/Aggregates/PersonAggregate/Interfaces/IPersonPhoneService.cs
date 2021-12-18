using System.Collections.Generic;
using System.Threading.Tasks;

namespace Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces
{
    public interface IPersonPhoneService
    {
        Task<List<PersonPhone>> FindAllAsync();
        Task<bool> InsertPersonPhone(PersonPhone personPhone);
        Task<bool> UpdatePersonPhone(PersonPhone personPhone);
        Task<bool> DeletePersonPhone(string phoneNumber);
    }
}
