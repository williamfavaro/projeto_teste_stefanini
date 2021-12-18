using Examples.Charge.Domain.Aggregates.PersonAggregate;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Examples.Charge.Application.Interfaces
{
    public interface IPhoneNumberTypeFacade
    {
        Task<IEnumerable<PhoneNumberType>> FindAllAsync();
        Task<bool> InsertPhoneNumberType(PhoneNumberType phoneNumberType);
        Task<bool> UpdatePhoneNumberType(PhoneNumberType phoneNumberType);
        Task<bool> DeletePhoneNumberType(int phoneNumberTypeID);
    }
}
