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
    public class HospitalManager : GenericManager<Hospital>, IHospitalService
    {
        IHospitalRepository _hospitalRepository;

        public HospitalManager(IHospitalRepository hospitalRepository) : base(hospitalRepository)
        {
            _hospitalRepository = hospitalRepository;
        }
    }
}
