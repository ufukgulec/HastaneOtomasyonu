using HastaneOtomasyonu.Dal.Abstract;
using HastaneOtomasyonu.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonu.Business
{
    public class PatientManager : GenericManager<Patient>
    {
        IPatientRepository _patientRepository;

        public PatientManager(IPatientRepository patientRepository) : base(patientRepository)
        {
            _patientRepository = patientRepository;
        }

        public List<Patient> DateOfPatients(DateTime dateTime)
        {
            return _patientRepository.DateOfPatients(dateTime);
        }

        public List<Patient> FemalePatients()
        {
            return _patientRepository.FemalePatients();
        }

        public List<Patient> MalePatients()
        {
            return _patientRepository.MalePatients();
        }
    }
}
