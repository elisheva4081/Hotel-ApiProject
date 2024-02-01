using Solid.core.Enentities;
using Solid.core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.data.Repository
{
    public class DateRepository : IDateRepository
    {
        private readonly DataContext _context;

        public DateRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<Date> AddDateAsync(Date date)
        {
            _context.Dates.Add(date);
            await _context.SaveChangesAsync();
            return date;
        }

        public async Task<Date> DeleteDateAsync(DateTime date)
        {
            var d = _context.Dates.Find(date);
            _context.Dates.Remove(d);
            await _context.SaveChangesAsync();
            return d;
        }

        public Date GetById(DateTime date)
        {
            var d = _context.Dates.Find(date);
            return d;
        }

        public List<Date> GetDates()
        {
            return _context.Dates.ToList();
        }

        public async Task<Date> UpdateDateAsync(string name, Date date)
        {
            var d = _context.Dates.Find(date);
            d.NameGuide = name;
            await _context.SaveChangesAsync();
            return d;
        }
    }
}
