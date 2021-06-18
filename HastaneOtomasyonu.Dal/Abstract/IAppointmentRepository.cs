using HastaneOtomasyonu.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonu.Dal.Abstract
{
    public interface IAppointmentRepository : IGenericRepository<Appointment>
    {
        List<Appointment> List();
        List<Appointment> List(Expression<Func<Appointment, bool>> expression);
    }
}
