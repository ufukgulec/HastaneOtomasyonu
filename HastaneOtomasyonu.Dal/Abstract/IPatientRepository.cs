using HastaneOtomasyonu.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonu.Dal.Abstract
{
    public interface IPatientRepository : IGenericRepository<Patient>
    {
        /// <summary>
        /// Erkek hasta listesi
        /// </summary>
        /// <returns></returns>
        List<Patient> MalePatients();
        /// <summary>
        /// Kadın hasta listesi
        /// </summary>
        /// <returns></returns>
        List<Patient> FemalePatients();
        /// <summary>
        /// Yıla göre hasta listesi
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        List<Patient> DateOfPatients(DateTime dateTime);
    }
}
