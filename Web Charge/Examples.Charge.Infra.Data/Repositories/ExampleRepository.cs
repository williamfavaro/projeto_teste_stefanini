using Examples.Charge.Domain.Aggregates.ExampleAggregate;
using Examples.Charge.Domain.Aggregates.ExampleAggregate.Interfaces;
using Examples.Charge.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Examples.Charge.Infra.Data.Repositories
{
    public class ExampleRepository : IExampleRepository
    {
        private readonly ExampleContext _context;

        public ExampleRepository(ExampleContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable<Example>> FindAllAsync() => await Task.Run(() => _context.Example);

        public async Task<bool> InsertExample(Example example)
        {
            await _context.AddAsync(example);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> UpdateExample(Example example)
        {
            _context.Update(example);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> DeleteExample(int id)
        {
            var example = await _context.Example.FindAsync(id);

            if (example != null)
            {
                _context.Remove(example);
                await _context.SaveChangesAsync();

                return true;
            }

            return false;
        }
    }
}
