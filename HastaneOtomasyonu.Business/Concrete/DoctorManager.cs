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
    public class DoctorManager : GenericManager<Doctor>, IDoctorService
    {
        IDoctorRepository _doctorRepository;

        public DoctorManager(IDoctorRepository doctorRepository) : base(doctorRepository)
        {
            _doctorRepository = doctorRepository;
        }
    }
}
