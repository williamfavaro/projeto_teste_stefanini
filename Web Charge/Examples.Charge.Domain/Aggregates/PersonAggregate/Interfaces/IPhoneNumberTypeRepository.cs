using System.Collections.Generic;
using System.Threading.Tasks;

namespace Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces
{
    public interface IPhoneNumberTypeRepository
    {
        Task<IEnumerable<PhoneNumberType>> FindAllAsync();
        Task<bool> InsertPhoneNumberType(PhoneNumberType phoneNumberType);
        Task<bool> UpdatePhoneNumberType(PhoneNumberType phoneNumberType);
        Task<bool> DeletePhoneNumberType(int phoneNumberTypeID);
    }
}
