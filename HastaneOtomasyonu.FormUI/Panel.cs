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
                cmbCity.Items.Add(item.Name);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = cmbCity.SelectedIndex + 1;
            HospitalBind(i);
        }

        private void HospitalBind(int i)
        {
            GenericManager<Hospital> hospitalManager = new GenericManager<Hospital>(new EfGenericRepository<Hospital>());
            var list = hospitalManager.GetAll(x => x.CityId == i).ToList();

            List<ComboBoxItem> combos = new List<ComboBoxItem>();

            foreach (var item in list)
            {
                combos.Add(new ComboBoxItem(item.Name, item.Id));
            }
            cmbHospital.ValueMember = "Value";
            cmbHospital.DisplayMember = "Display";
            cmbHospital.DataSource = combos;
        }

        private void cmbHospital_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxItem cbi = (ComboBoxItem)cmbHospital.SelectedItem;
            int HospitalId = cbi.Value;
            PoliclinicBind(HospitalId);
        }

        private void PoliclinicBind(int HospitalId)
        {

            GenericManager<Policlinic> policlinicManager = new GenericManager<Policlinic>(new EfGenericRepository<Policlinic>());
            var list = policlinicManager.GetAll(x => x.HospitalId == HospitalId).ToList();

            List<ComboBoxItem> combos = new List<ComboBoxItem>();

            foreach (var item in list)
            {
                combos.Add(new ComboBoxItem(item.Unit.Name, item.Id));
            }
            cmbPoliclinic.ValueMember = "Value";
            cmbPoliclinic.DisplayMember = "Display";
            cmbPoliclinic.DataSource = combos;
        }

        private void cmbPoliclinic_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxItem cbi = (ComboBoxItem)cmbPoliclinic.SelectedItem;
            int PoliclinicId = cbi.Value;

            DoctorBind(PoliclinicId);
        }

        private void DoctorBind(int PoliclinicId)
        {
            GenericManager<Policlinic> polManager = new GenericManager<Policlinic>(new EfGenericRepository<Policlinic>());
            var pol = polManager.Get(PoliclinicId);

            GenericManager<Doctor> DoctorManager = new GenericManager<Doctor>(new EfGenericRepository<Doctor>());
            var list = DoctorManager.GetAll(x => x.HospitalId == pol.HospitalId && x.UnitId == pol.UnitId);

            List<ComboBoxItem> combos = new List<ComboBoxItem>();

            foreach (var item in list)
            {
                combos.Add(new ComboBoxItem(item.Name + " " + item.Surname, item.Id));
            }
            cmbDoctor.ValueMember = "Value";
            cmbDoctor.DisplayMember = "Display";
            cmbDoctor.DataSource = combos;
        }

        private void cmbDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            dateTimePicker2.Visible = true;
            ComboBoxItem cbi = (ComboBoxItem)cmbDoctor.SelectedItem;
            int DoctorId = cbi.Value;
            AppointmentHours(DateTime.Now, DoctorId);
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            ComboBoxItem cbi = (ComboBoxItem)cmbDoctor.SelectedItem;
            int DoctorId = cbi.Value;
            AppointmentHours(dateTimePicker2.Value, DoctorId);
        }
        private void AppointmentHours(DateTime dateTime, int doctorId)
        {
            Button[,] buttons = new Button[4, 6];
            int genişlik = 100;
            int yükseklik = 50;
            int top = 200;
            int left = 150;
            DateTime date = new DateTime(2021, 06, 1, 8, 0, 0);
            AppointmentManager appointmentManager = new AppointmentManager(new EfAppointmentRepository());
            var list = appointmentManager.GetAll(x => x.Date == dateTime.Date && x.DoctorId==doctorId).ToList();

            for (int i = 0; i <= buttons.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= buttons.GetUpperBound(1); j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Width = genişlik;
                    buttons[i, j].Height = yükseklik;
                    buttons[i, j].Top = top;
                    buttons[i, j].Left = left;
                    buttons[i, j].Text = date.ToString("HH:mm");
                    var obj = list.Where(x => x.Hour.ToString().Contains(buttons[i, j].Text)).FirstOrDefault();
                    if (obj != null)
                    {
                        buttons[i, j].Enabled = false;
                    }
                    else
                    {
                        buttons[i, j].Enabled = true;
                    }
                    this.Controls.Add(buttons[i, j]);
                    left += 110;
                    date = date.AddMinutes(30);
                }
                top += 60;
                left = 150;
            }
        }
    }
}
