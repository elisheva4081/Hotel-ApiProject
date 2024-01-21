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
        Date GetById(string id);
        void AddDate(Date date);
        void UpdateDate(string id, Date date);
        void DeleteDate(string id);
    }
}
