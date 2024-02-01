using Solid.core.Enentities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.core.Services
{
    public interface IDateService
    {
        List<Date> GetDates();
        Date GetById(DateTime date);
        Task<Date> AddDateAsync(Date date);
        Task<Date> UpdateDateAsync(string id, Date date);
        Task<Date> DeleteDateAsync(DateTime date);
    }
}
