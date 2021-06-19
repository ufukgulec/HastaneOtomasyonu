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
        GenericManager<Hospital> hospitalManager = new GenericManager<Hospital>(new EfGenericRepository<Hospital>());
        GenericManager<Policlinic> policlinicManager = new GenericManager<Policlinic>(new EfGenericRepository<Policlinic>());
        GenericManager<Doctor> DoctorManager = new GenericManager<Doctor>(new EfGenericRepository<Doctor>());
        AppointmentManager appointmentManager = new AppointmentManager(new EfAppointmentRepository());
        PatientManager patientManager = new PatientManager(new EfPatientRepository());
        GenericManager<City> cityManager = new GenericManager<City>(new EfGenericRepository<City>());
        public Patient patient;//Formlar Arası Nesne Çekmek İçin Kullanılır.(Login.Form>Panel.Form)

        Hospital CHospital;
        Policlinic CPoliclinic;
        Doctor CDoctor;
        public Panel()
        {
            InitializeComponent();
        }
        private void Panel_Load(object sender, EventArgs e)
        {
            CityBind();
            AppointmentBind();
            PatientInformationBind();
            AppointmentResult();
        }

        private void AppointmentResult()
        {
            cmbHospital.Enabled = false;
            cmbPoliclinic.Enabled = false;
            cmbDoctor.Enabled = false;
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

            var list = appointmentManager.List(x => x.PatientId == patient.Id);
            foreach (var item in list)
            {
                string[] row = new string[] { item.Policlinic.Unit.Name,
                        item.Doctor.Name+" "+item.Doctor.Surname,
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


            foreach (var item in cityManager.GetAll().ToList())
            {
                cmbCity.Items.Add(item.Name);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbHospital.Enabled = true;
            int CityID = cmbCity.SelectedIndex + 1;
            HospitalBind(CityID);
        }

        private void HospitalBind(int? i)
        {
            List<Hospital> list;
            if (i != null)
            {
                list = hospitalManager.GetAll(x => x.CityId == i).ToList();
            }
            else
            {
                list = hospitalManager.GetAll().ToList();
            }

            List<ComboBoxItem> combos = new List<ComboBoxItem>();

            foreach (var item in list)
            {
                combos.Add(new ComboBoxItem(item.Name, item.Id));
            }
            ComboBoxProp(cmbHospital, combos);
        }
        private void ComboBoxProp(ComboBox comboBox, List<ComboBoxItem> combos)
        {
            comboBox.ValueMember = "Value";
            comboBox.DisplayMember = "Display";
            comboBox.DataSource = combos;
        }
        private void cmbHospital_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbPoliclinic.Enabled = true;
            ComboBoxItem cbi = (ComboBoxItem)cmbHospital.SelectedItem;
            CHospital = hospitalManager.Get(cbi.Value);

            PoliclinicBind(CHospital.Id);
        }

        private void PoliclinicBind(int HospitalId)
        {
            var list = policlinicManager.GetAll(x => x.HospitalId == HospitalId).ToList();

            List<ComboBoxItem> combos = new List<ComboBoxItem>();

            foreach (var item in list)
            {
                combos.Add(new ComboBoxItem(item.Unit.Name, item.Id));
            }
            ComboBoxProp(cmbPoliclinic, combos);
        }

        private void cmbPoliclinic_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoctor.Enabled = true;
            ComboBoxItem cbi = (ComboBoxItem)cmbPoliclinic.SelectedItem;
            CPoliclinic = policlinicManager.Get(cbi.Value);

            DoctorBind(CPoliclinic.Id);
        }

        private void DoctorBind(int PoliclinicId)
        {
            var pol = policlinicManager.Get(PoliclinicId);

            var list = DoctorManager.GetAll(x => x.HospitalId == pol.HospitalId && x.UnitId == pol.UnitId);

            List<ComboBoxItem> combos = new List<ComboBoxItem>();

            foreach (var item in list)
            {
                combos.Add(new ComboBoxItem(item.Name + " " + item.Surname, item.Id));
            }
            ComboBoxProp(cmbDoctor, combos);
        }

        private void cmbDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            dateTimePicker2.Visible = true;
            ComboBoxItem cbi = (ComboBoxItem)cmbDoctor.SelectedItem;
            CDoctor = DoctorManager.Get(cbi.Value);

            AppointmentHours(DateTime.Now, CDoctor.Id);
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            ComboBoxItem cbi = (ComboBoxItem)cmbDoctor.SelectedItem;
            AppointmentHours(dateTimePicker2.Value, CDoctor.Id);
        }
        private void AppointmentHours(DateTime dateTime, int doctorId)
        {
            var list = appointmentManager.GetAll(x => x.Date == dateTime.Date && x.DoctorId == doctorId).ToList();
            HoursButtons(list);
        }

        private void HoursButtons(List<Appointment> list)
        {
            panel2.Controls.Clear();
            Button[,] buttons = new Button[6, 4];
            int genişlik = 100;
            int yükseklik = 50;
            int top = 0;
            int left = 0;
            DateTime date = new DateTime(2021, 06, 1, 8, 0, 0);

            for (int i = 0; i <= buttons.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= buttons.GetUpperBound(1); j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Width = genişlik;
                    buttons[i, j].Height = yükseklik;
                    buttons[i, j].Top = top;
                    buttons[i, j].ForeColor = Color.White;
                    buttons[i, j].Cursor = Cursors.Hand;
                    buttons[i, j].FlatStyle = FlatStyle.Popup;
                    buttons[i, j].Click += new System.EventHandler(this.Randevu);
                    buttons[i, j].Left = left;
                    buttons[i, j].Text = date.ToString("HH:mm");
                    var obj = list.Where(x => x.Hour.ToString().Contains(buttons[i, j].Text)).FirstOrDefault();
                    if (obj != null)
                    {
                        buttons[i, j].Enabled = false;
                        buttons[i, j].BackColor = Color.Red;
                    }
                    else
                    {
                        buttons[i, j].Enabled = true;
                        buttons[i, j].BackColor = Color.Green;
                    }
                    panel2.Controls.Add(buttons[i, j]);
                    left += 110;
                    date = date.AddMinutes(30);
                }
                top += 60;
                left = 0;
            }
        }
        private void Randevu(object sender, EventArgs e)
        {
            Button current = (Button)sender;
            string message = String.Format(
                "RANDEVUNUZ \n" + "Poliklinik: {0}\n" + "Doktor: {1} {2}\n" + "Saat: {3}\n" + "Adınız Soyadınız: {4} {5}" + " onaylıyorsanız Evet'e basınız."
                , CPoliclinic.Unit.Name, CDoctor.Name, CDoctor.Surname, current.Text, patient.Name, patient.Surname
                );
            string title = "Randevu Kontrol";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Appointment appointment = new Appointment
                {
                    PatientId = patient.Id,
                    DoctorId = CDoctor.Id,
                    PoliclinicId = CPoliclinic.Id,
                    Hour = TimeSpan.Parse(current.Text),
                    Date = dateTimePicker2.Value
                };
                appointmentManager.Create(appointment);
                AppointmentHours(dateTimePicker2.Value, CDoctor.Id);
            }
            else
            {

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtparola.Enabled = true;
            button4.Text = "Onayla";
            button4.BackColor = Color.Red;
            if (button4.Text.Contains("Onayla"))
            {
                button4.BackColor = Color.Green;
                patient.Password = txtparola.Text;
                patientManager.Update(patient);

            }
        }
    }
}
