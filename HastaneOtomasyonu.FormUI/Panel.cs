using HastaneOtomasyonu.Business;
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
    public partial class Panel : Form
    {
        public Patient patient;
        public Panel()
        {
            InitializeComponent();
        }
        private void Panel_Load(object sender, EventArgs e)
        {
            CityBind();
            AppointmentBind();
            PatientInformationBind();
        }

        private void PatientInformationBind()
        {
            btnPatient.Text = patient.Name + " " + patient.Surname;
            txtisim.Text = patient.Name;
            txtsoyisim.Text = patient.Surname;
            txtadres.Text = patient.City.Name;
            txtTc.Text = patient.IdentificationNumber;
            txtparola.Text = patient.Password;
            txttel.Text = patient.Phone;
            dateTimePicker1.Value = patient.DateOfBirth;
        }

        private void AppointmentBind()
        {
            AppointmentManager appointmentManager = new AppointmentManager(new EfAppointmentRepository());


            var list = appointmentManager.List(x => x.PatientId == patient.Id);
            foreach (var item in list)
            {
                string[] row = new string[] { item.Policlinic.Unit.Name,
                        item.Doctor.Name,
                        item.Date.ToString("dd/MM/yyyy"),
                        item.Hour.ToString() };
                if (item.Date < DateTime.Now)
                {
                    dataGridView2.Rows.Add(row);
                }
                else
                {
                    dataGridView1.Rows.Add(row);
                }
            }
        }

        private void CityBind()
        {
            GenericManager<City> cityManager = new GenericManager<City>(new EfGenericRepository<City>());
            foreach (var item in cityManager.GetAll().ToList())
            {
                comboBox1.Items.Add(item.Name);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
