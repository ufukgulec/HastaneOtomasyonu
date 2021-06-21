using HastaneOtomasyonu.Dal.Abstract;
using HastaneOtomasyonu.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonu.Dal.Concrete.EntityFramework.Repository
{
    public class EfPoliclinicRepository : EfGenericRepository<Policlinic>, IPoliclinicRepository
    {
    }
}
