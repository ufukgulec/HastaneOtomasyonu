using HastaneOtomasyonu.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonu.Business.Abstract
{
    public interface IPatientService : IGenericService<Patient>
    {
        /// <summary>
        /// Kullanıcı Girişi
        /// </summary>
        /// <param name="tc"></param>
        /// <param name="parola"></param>
        /// <returns></returns>
        Patient Login(string tc, string parola);
    }
}
