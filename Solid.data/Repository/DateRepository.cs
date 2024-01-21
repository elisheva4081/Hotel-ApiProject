using Solid.core.Enentities;
using Solid.core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.data.Repository
{
    internal class DateRepository : IDateRepository
    {
        private readonly DataContext _context;

        public DateRepository(DataContext context)
        {
            _context = context;
        }

        public void AddDate(Date date)
        {
            _context.Dates.Add(date);
        }

        public void DeleteDate(string name)
        {
            var d = _context.Dates.Find(d => d.NameGuide == name);
            _context.Dates.Remove(d);
        }

        public Date GetById(string name)
        {
            var d = _context.Dates.Find(d => d.NameGuide == name);
            return d;
        }

        public List<Date> GetDates()
        {
            return _context.Dates;
        }

        public void UpdateDate(string name, Date date)
        {
            var d = _context.Dates.Find(d => d.NameGuide == name);
            d = date;
        }
    }
}
