using HastaneOtomasyonu.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonu.Business.Abstract
{
    public interface IAppointmentService : IGenericService<Appointment>
    {
        /// <summary>
        /// List olarak Rendevu Listesi döner.
        /// </summary>
        /// <returns>List<Appointment></returns>
        List<Appointment> List();
        /// <summary>
        /// List olarak sorgulu Rendevu Listesi döner.
        /// </summary>
        /// <param name="expression">Sorgu</param>
        /// <returns>List<Appointment></returns>
        List<Appointment> List(Expression<Func<Appointment, bool>> expression);
    }
}
