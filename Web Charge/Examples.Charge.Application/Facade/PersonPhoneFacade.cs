using Examples.Charge.Application.Interfaces;
using Examples.Charge.Domain.Aggregates.PersonAggregate;
using Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Examples.Charge.Application.Facade
{
    public class PersonPhoneFacade : IPersonPhoneFacade
    {
        private readonly IPersonPhoneService _personPhoneService;

        public PersonPhoneFacade(IPersonPhoneService personPhoneService)
        {
            _personPhoneService = personPhoneService;
        }

        public async Task<List<PersonPhone>> FindAllAsync() =>
            await _personPhoneService.FindAllAsync();

        public async Task<bool> InsertPersonPhone(PersonPhone personPhone) =>
            await _personPhoneService.InsertPersonPhone(personPhone);

        public async Task<bool> UpdatePersonPhone(PersonPhone personPhone) =>
            await _personPhoneService.UpdatePersonPhone(personPhone);

        public async Task<bool> DeletePersonPhone(string phoneNumber) =>
            await _personPhoneService.DeletePersonPhone(phoneNumber);
    }
}
