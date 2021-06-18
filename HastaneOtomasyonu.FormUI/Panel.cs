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
            btnPatient.Text = patient.name + " " + patient.surname;
            txtisim.Text = patient.name;
            txtsoyisim.Text = patient.surname;
            txtadres.Text = patient.address;
            txtTc.Text = patient.identificationnumber;
            txtparola.Text = patient.password;
            txttel.Text = patient.phonenumber;
            dateTimePicker1.Value = (DateTime)patient.dateofbirth;
        }

        private void AppointmentBind()
        {
            AppointmentManager appointmentManager = new AppointmentManager(new EfAppointmentRepository());


            var list = appointmentManager.List();
            foreach (var item in list)
            {
                string[] row = new string[] { item.Policlinic.name,
                        item.Doctor.name,
                        item.date.ToString("dd/MM/yyyy"),
                        item.hour.ToString() };
                if (item.date < DateTime.Now)
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
                comboBox1.Items.Add(item.name);
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
