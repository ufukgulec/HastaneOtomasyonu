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
    public class PoliclinicManager : GenericManager<Policlinic>, IPoliclinicService
    {
        IPoliclinicRepository _policlinicRepository;
        public PoliclinicManager(IPoliclinicRepository policlinicRepository) : base(policlinicRepository)
        {
            _policlinicRepository = policlinicRepository;
        }
    }
}
