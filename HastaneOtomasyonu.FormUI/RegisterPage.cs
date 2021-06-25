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

    public partial class RegisterPage : MaterialForm
    {
        public Form form;
        IPatientService patientService = new PatientManager(new EfPatientRepository());
        IGenericService<City> cityService = new GenericManager<City>(new EfGenericRepository<City>());

        public RegisterPage()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Red800, Primary.Red900, Primary.Red500, Accent.Red200, TextShade.WHITE);

        }

        private void RegisterPage_Load(object sender, EventArgs e)
        {
            form.Hide();
            var list = cityService.GetAll().ToList();
            foreach (var item in list)
            {
                cmbCity.Items.Add(item.Name);
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            form.Show();
        }

        private void btnRegis_Click(object sender, EventArgs e)
        {
            string gender = "";
            if (rbMale.Checked)
            {
                gender = "E";
            }
            else if (rbFemale.Checked)
            {
                gender = "K";
            }
            else
            {
                gender = "";
            }

            try
            {
                Patient patient = new Patient()
                {
                    Name = txtName.Text,
                    Surname = txtSurname.Text,
                    IdentificationNumber = txtId.Text,
                    Phone = txtPhone.Text,
                    DateOfBirth = DateTime.Parse(txtBday.Text),
                    Gender = gender,
                    DateOfRegistration = DateTime.Now.Date,
                    CityId = cmbCity.SelectedIndex + 1,
                    Password = "mhrs" + txtId.Text.Substring(0, 6) // "mhrs402734"

                };
                patientService.Create(patient);
                LoginPage login = new LoginPage();
                MaterialMessageBox.Show(string.Format("{0} {1} şifreniz {2} \n Değiştirmek için Hesap Bilgilerinize giriniz...", patient.Name, patient.Surname, patient.Password), "İlk Giriş", MessageBoxButtons.YesNo);
                login.sign(patient.IdentificationNumber, patient.Password);

            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }

        private void RegisterPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.Show();
        }
    }
}
