using System.Collections.Generic;
using System.Threading.Tasks;

namespace Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces
{
    public interface IPhoneNumberTypeService
    {
        Task<List<PhoneNumberType>> FindAllAsync();
        Task<bool> InsertPhoneNumberType(PhoneNumberType phoneNumberType);
        Task<bool> UpdatePhoneNumberType(PhoneNumberType phoneNumberType);
        Task<bool> DeletePhoneNumberType(int phoneNumberTypeID);
    }
}
