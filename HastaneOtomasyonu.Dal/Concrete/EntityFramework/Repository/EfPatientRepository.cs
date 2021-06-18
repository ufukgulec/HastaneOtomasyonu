using HastaneOtomasyonu.Dal.Abstract;
using HastaneOtomasyonu.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonu.Dal.Concrete.EntityFramework.Repository
{
    public class EfPatientRepository : EfGenericRepository<Patient>, IPatientRepository
    {
        public EfPatientRepository() : base()
        {

        }

        public Patient Login(string tc, string parola)
        {
            var patient = _context.Patient.Where(x => x.identificationnumber == tc && x.password == parola).FirstOrDefault();
            
            return patient;
        }
    }
}
