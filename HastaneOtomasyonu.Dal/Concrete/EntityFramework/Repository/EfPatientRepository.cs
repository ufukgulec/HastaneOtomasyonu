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
        public List<Patient> DateOfPatients(DateTime dateTime)
        {
            return _context.Patient.Where(x => x.dateofregistration == dateTime).ToList();
        }

        public List<Patient> FemalePatients()
        {
            return _context.Patient.Where(x => x.gender.Contains("k")).ToList();
        }

        public List<Patient> MalePatients()
        {
            return _context.Patient.Where(x => x.gender.Contains("e")).ToList();
        }
    }
}
