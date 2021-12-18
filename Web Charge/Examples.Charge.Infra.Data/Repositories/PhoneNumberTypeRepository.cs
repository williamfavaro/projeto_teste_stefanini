using Examples.Charge.Domain.Aggregates.PersonAggregate;
using Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces;
using Examples.Charge.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Examples.Charge.Infra.Data.Repositories
{
    public class PhoneNumberTypeRepository : IPhoneNumberTypeRepository
    {
        private readonly ExampleContext _context;

        public PhoneNumberTypeRepository(ExampleContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable<PhoneNumberType>> FindAllAsync() => await Task.Run(() => _context.PhoneNumberType);

        public async Task<bool> InsertPhoneNumberType(PhoneNumberType phoneNumberType)
        {
            await _context.AddAsync(phoneNumberType);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> UpdatePhoneNumberType(PhoneNumberType phoneNumberType)
        {
            _context.Update(phoneNumberType);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> DeletePhoneNumberType(int phoneNumberTypeID)
        {
            var phoneNumberType = await _context.PhoneNumberType.FindAsync(phoneNumberTypeID);

            if (phoneNumberType != null)
            {
                _context.Remove(phoneNumberType);
                await _context.SaveChangesAsync();

                return true;
            }

            return false;
        }
    }
}
