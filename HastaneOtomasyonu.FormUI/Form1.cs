using HastaneOtomasyonu.Business;
using HastaneOtomasyonu.Dal.Abstract;
using HastaneOtomasyonu.Dal.Concrete.EntityFramework.Repository;
using HastaneOtomasyonu.Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyonu.FormUI
{
    public partial class Form1 : Form
    {
        GenericManager<Patient> patientService = new GenericManager<Patient>(new EfGenericRepository<Patient>());
        public Form1()
        {
            InitializeComponent();
        }
    }
}
