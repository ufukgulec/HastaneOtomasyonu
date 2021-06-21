using HastaneOtomasyonu.Business.Abstract;
using HastaneOtomasyonu.Dal.Abstract;
using HastaneOtomasyonu.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonu.Business
{
    public class AppointmentManager : GenericManager<Appointment>, IAppointmentService
    {
        IAppointmentRepository _appointmentRepository;
        public AppointmentManager(IAppointmentRepository appointmentRepository) : base(appointmentRepository)
        {
            _appointmentRepository = appointmentRepository;
        }
        public List<Appointment> List()
        {
            return _appointmentRepository.List();
        }

        public List<Appointment> List(Expression<Func<Appointment, bool>> expression)
        {
            return _appointmentRepository.List(expression);
        }
    }
}
