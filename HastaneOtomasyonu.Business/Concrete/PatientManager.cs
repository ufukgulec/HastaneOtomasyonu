using HastaneOtomasyonu.Business.Abstract;
using HastaneOtomasyonu.Dal.Abstract;
using HastaneOtomasyonu.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonu.Business
{
    public class PatientManager : GenericManager<Patient>, IPatientService
    {
        IPatientRepository _patientRepository;

        public PatientManager(IPatientRepository patientRepository) : base(patientRepository)
        {
            _patientRepository = patientRepository;
        }
        public Patient Login(string tc, string parola)
        {
            var patient = _patientRepository.Login(tc, parola);
            return patient;
        }
    }
}
