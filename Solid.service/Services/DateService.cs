using Solid.core.Enentities;
using Solid.core.Repositories;
using Solid.core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.service.Repository
{
    public class DateService:IDateService
    {
        private readonly IDateRepository _idateRepository;
        public DateService(IDateRepository idateRepository)
        {
            _idateRepository=idateRepository;
        }

        public async Task<Date> AddDateAsync(Date date)
        {

            return await _idateRepository.AddDateAsync(date);
        }

        public async Task<Date> DeleteDateAsync(DateTime date)
        {
            return await _idateRepository.DeleteDateAsync(date);
        }

        public Date GetById(DateTime date)
        {
            return _idateRepository.GetById(date);
        }

        public List<Date> GetDates()
        {
            return _idateRepository.GetDates();
        }

        public async Task<Date> UpdateDateAsync(string name, Date date)
        {
            return await _idateRepository.UpdateDateAsync(name, date);
        }
    }
}
