using Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examples.Charge.Domain.Aggregates.PersonAggregate
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _personRepository;
        public PersonService(IPersonRepository personRepository)
        {
            _personRepository = personRepository;

        }

        public async Task<List<Person>> FindAllAsync() => (await _personRepository.FindAllAsync()).ToList();

        public async Task<bool> InsertPerson(Person person) =>
            await _personRepository.InsertPerson(person);

        public async Task<bool> UpdatePerson(Person person) =>
            await _personRepository.UpdatePerson(person);

        public async Task<bool> DeletePerson(int businessEntityID) =>
            await _personRepository.DeletePerson(businessEntityID);
    }
}
