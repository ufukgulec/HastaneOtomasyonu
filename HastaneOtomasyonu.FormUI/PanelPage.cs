using HastaneOtomasyonu.Business;
using HastaneOtomasyonu.Business.Abstract;
using HastaneOtomasyonu.Dal.Concrete.EntityFramework.Repository;
using HastaneOtomasyonu.Entities.Models;
using MaterialSkin;
using MaterialSkin.Controls;
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
    public partial class PanelPage : MaterialForm
    {
        public Patient patient;//LoginPage'den geliyor.
        IHospitalService hospitalService = new HospitalManager(new EfHospitalRepository());
        IPoliclinicService policlinicService = new PoliclinicManager(new EfPoliclinicRepository());
        IDoctorService doctorService = new DoctorManager(new EfDoctorRepository());
        IAppointmentService appointmentService = new AppointmentManager(new EfAppointmentRepository());
        IPatientService patientService = new PatientManager(new EfPatientRepository());
        GenericManager<City> cityManager = new GenericManager<City>(new EfGenericRepository<City>());

        Hospital CHospital;
        Policlinic CPoliclinic;
        Doctor CDoctor;

        public Form form;
        public PanelPage()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Red800, Primary.Red900, Primary.Red500, Accent.Red200, TextShade.WHITE);

        }

        private void PanelPage_Load(object sender, EventArgs e)
        {
            AppointmentBind();
        }

        private void AppointmentBind()
        {
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            var list = appointmentService.List(x => x.PatientId == patient.Id);
            foreach (var item in list)
            {
                string[] row = new string[] { item.ID.ToString(),item.Policlinic.Unit.Name,
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

        private void PatientInformationBind()
        {

            txtName.Text = patient.Name;
            txtSurname.Text = patient.Surname;
            txtId.Text = patient.IdentificationNumber;
            txtPassword.Text = patient.Password;
            txtPhone.Text = patient.Phone;
            txtDate.Text = patient.DateOfBirth.ToString("dd/MM/yyyy");
        }


        private void AppointmentResult()
        {
            cmbHospital.Enabled = false;
            cmbPoliclinic.Enabled = false;
            cmbDoctor.Enabled = false;
        }

        private void CityBind()
        {
            foreach (var item in cityManager.GetAll().ToList())
            {
                cmbCity.Items.Add(item.Name);
            }
            cmbCity.SelectedIndex = patient.CityId - 1;
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
                list = hospitalService.GetAll(x => x.CityId == i).ToList();
            }
            else
            {
                list = hospitalService.GetAll().ToList();
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
            CHospital = hospitalService.Get(cbi.Value);

            PoliclinicBind(CHospital.Id);
        }
        private void PoliclinicBind(int HospitalId)
        {
            var list = policlinicService.GetAll(x => x.HospitalId == HospitalId).ToList();

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
            CPoliclinic = policlinicService.Get(cbi.Value);

            DoctorBind(CPoliclinic.Id);
        }
        private void DoctorBind(int PoliclinicId)
        {
            var pol = policlinicService.Get(PoliclinicId);

            var list = doctorService.GetAll(x => x.HospitalId == pol.HospitalId && x.UnitId == pol.UnitId);

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
            CDoctor = doctorService.Get(cbi.Value);

            AppointmentHours(DateTime.Now, CDoctor.Id);
        }
        private void AppointmentHours(DateTime dateTime, int doctorId)
        {
            var list = appointmentService.GetAll(x => x.Date == dateTime.Date && x.DoctorId == doctorId).ToList();
            HoursButtons(list);
        }
        private void HoursButtons(List<Appointment> list)
        {
            panel2.Controls.Clear();
            //Button[,] materialButtons = new Button[6, 4];
            MaterialButton[,] materialButtons = new MaterialButton[6, 4];
            int genişlik = 80;
            int yükseklik = 50;
            int top = 0;
            int left = 0;
            DateTime date = new DateTime(2021, 06, 1, 8, 0, 0);

            for (int i = 0; i <= materialButtons.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= materialButtons.GetUpperBound(1); j++)
                {
                    materialButtons[i, j] = new MaterialButton();
                    materialButtons[i, j].MinimumSize = new System.Drawing.Size(genişlik, yükseklik);
                    //materialButtons[i, j].MinimumSize.Height= yükseklik;
                    materialButtons[i, j].Top = top;
                    materialButtons[i, j].ForeColor = Color.White;
                    materialButtons[i, j].Cursor = Cursors.Hand;
                    materialButtons[i, j].FlatStyle = FlatStyle.Popup;
                    materialButtons[i, j].Click += new System.EventHandler(this.Randevu);
                    materialButtons[i, j].Left = left;
                    materialButtons[i, j].Text = date.ToString("HH:mm");
                    var obj = list.Where(x => x.Hour.ToString().Contains(materialButtons[i, j].Text)).FirstOrDefault();
                    if (obj != null)
                    {
                        materialButtons[i, j].Enabled = false;
                        materialButtons[i, j].BackColor = Color.Transparent;
                    }
                    else
                    {
                        materialButtons[i, j].Enabled = true;
                        materialButtons[i, j].BackColor = Color.Green;
                    }
                    panel2.Controls.Add(materialButtons[i, j]);
                    left += (genişlik + 10);
                    date = date.AddMinutes(30);
                }
                top += (yükseklik + 10);
                left = 0;
            }
        }
        private void Randevu(object sender, EventArgs e)
        {
            Button current = (Button)sender;
            string message = String.Format(
                "RANDEVUNUZ \n" + "Hastane:{6}\nPoliklinik: {0}\nDoktor: {1} {2}\nSaat: {3}\nAdınız Soyadınız: {4} {5}" + " onaylıyorsanız Evet'e basınız."
                , CPoliclinic.Unit.Name, CDoctor.Name, CDoctor.Surname, current.Text, patient.Name, patient.Surname, CHospital.Name
                );
            string title = "Randevu Kontrol";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MaterialMessageBox.Show(message, title, buttons);
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
                appointmentService.Create(appointment);
                AppointmentHours(dateTimePicker2.Value, CDoctor.Id);
                AppointmentBind();
            }
            else
            {

            }
        }
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            ComboBoxItem cbi = (ComboBoxItem)cmbDoctor.SelectedItem;
            AppointmentHours(dateTimePicker2.Value, CDoctor.Id);
        }



        private void tabPage2_Enter(object sender, EventArgs e)
        {
            PatientInformationBind();
        }

        private void tabPage3_Enter(object sender, EventArgs e)
        {
            CityBind();
            AppointmentResult();
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            btnSubmit.Visible = true;
            materialButton2.Visible = false;
            txtPassword.Enabled = true;
            txtPassword.Password = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string message = String.Format("{0} {1}\n Şifre Değişikliğini onaylıyor musunuz ?"
                , patient.Name, patient.Surname);
            string title = "Şifre Değişikliği";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MaterialMessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                patient.Password = txtPassword.Text;
                patientService.Update(patient);
                PatientInformationBind();
                btnSubmit.Visible = false;
                materialButton2.Visible = true;
                txtPassword.Password = true;
                txtPassword.Enabled = false;
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = int.Parse(this.dataGridView1.Rows[e.RowIndex].Cells["Id"].Value.ToString());
            var app = appointmentService.Get(i);
            dtlDoctor.Text = String.Format("Dr. {0} {1}", app.Doctor.Name, app.Doctor.Surname);
            dtlPol.Text = String.Format("{0}-{1} Polikliniği", app.Doctor.Hospital.Name, app.Policlinic.Unit.Name);
            dtlDate.Text = String.Format("Tarih: {0} Saat: {1}", app.Date.ToString("dd.MM.yyyy dddd"), app.Hour.ToString(""));
            materialTabControl1.SelectedTab = tabPage4;

        }

        private void PanelPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.Show();
        }
    }
}
