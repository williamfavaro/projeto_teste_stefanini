using Examples.Charge.Domain.Aggregates.PersonAggregate;
using Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces;
using Examples.Charge.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examples.Charge.Infra.Data.Repositories
{
    public class PersonPhoneRepository : IPersonPhoneRepository
    {
        private readonly ExampleContext _context;

        public PersonPhoneRepository(ExampleContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable<PersonPhone>> FindAllAsync() => await Task.Run(() => _context.PersonPhone);

        public async Task<bool> InsertPersonPhone(PersonPhone personPhone)
        {
            await _context.PersonPhone.AddAsync(personPhone);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> UpdatePersonPhone(PersonPhone personPhone)
        {
            _context.PersonPhone.Update(personPhone);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> DeletePersonPhone(string phoneNumber)
        {
            var personPhone = await _context.PersonPhone.FindAsync(phoneNumber);

            if (personPhone != null)
            {
                _context.Remove(personPhone);
                await _context.SaveChangesAsync();

                return true;
            }

            return false;
        }
    }
}
