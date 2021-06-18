using HastaneOtomasyonu.Dal.Abstract;
using HastaneOtomasyonu.Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonu.Dal.Concrete.EntityFramework.Repository
{
    public class EfAppointmentRepository : EfGenericRepository<Appointment>, IAppointmentRepository
    {
        public List<Appointment> List()
        {
            return GetAll().ToList();
        }

        public List<Appointment> List(Expression<Func<Appointment, bool>> expression)
        {
            return GetAll(expression).Include(x => x.Doctor).Include(x => x.Policlinic).ToList();
        }
    }
}
