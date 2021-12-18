using Examples.Charge.Application.Interfaces;
using Examples.Charge.Domain.Aggregates.PersonAggregate;
using Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Examples.Charge.Application.Facade
{
    public class PhoneNumberTypeFacade : IPhoneNumberTypeFacade
    {
        private readonly IPhoneNumberTypeService _phoneNumberTypeService;

        public PhoneNumberTypeFacade(IPhoneNumberTypeService phoneNumberTypeService)
        {
            _phoneNumberTypeService = phoneNumberTypeService;
        }

        public async Task<IEnumerable<PhoneNumberType>> FindAllAsync() =>
            await _phoneNumberTypeService.FindAllAsync();

        public async Task<bool> InsertPhoneNumberType(PhoneNumberType phoneNumberType) =>
            await _phoneNumberTypeService.InsertPhoneNumberType(phoneNumberType);

        public async Task<bool> UpdatePhoneNumberType(PhoneNumberType phoneNumberType) =>
            await _phoneNumberTypeService.UpdatePhoneNumberType(phoneNumberType);

        public async Task<bool> DeletePhoneNumberType(int phoneNumberTypeID) =>
            await _phoneNumberTypeService.DeletePhoneNumberType(phoneNumberTypeID);
    }
}
