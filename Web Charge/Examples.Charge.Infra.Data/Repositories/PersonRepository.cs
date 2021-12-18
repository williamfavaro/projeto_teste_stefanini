using Examples.Charge.Domain.Aggregates.PersonAggregate;
using Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces;
using Examples.Charge.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Examples.Charge.Infra.Data.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly ExampleContext _context;

        public PersonRepository(ExampleContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable<Person>> FindAllAsync() => await Task.Run(() => _context.Person);

        public async Task<bool> InsertPerson(Person person)
        {
            await _context.AddAsync(person);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> UpdatePerson(Person person)
        {
            _context.Update(person);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> DeletePerson(int businessEntityID)
        {
            var person = await _context.Person.FindAsync(businessEntityID);

            if (person != null)
            {
                _context.Remove(person);
                await _context.SaveChangesAsync();

                return true;
            }

            return false;
        }
    }
}
