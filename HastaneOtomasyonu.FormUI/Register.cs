using HastaneOtomasyonu.Business;
using HastaneOtomasyonu.Business.Abstract;
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
    public partial class Register : Form
    {
        IPatientService patientService = new PatientManager(new EfPatientRepository());
        IGenericService<City> cityService = new GenericManager<City>(new EfGenericRepository<City>());
        public Register()
        {
            InitializeComponent();
        }
        #region Placeholder
        private void txtIsım_Enter(object sender, EventArgs e)
        {
            if (txtIsım.Text == "İsminiz")
            {
                txtIsım.Text = "";
                txtIsım.ForeColor = Color.Black;
            }
        }

        private void txtIsım_Leave(object sender, EventArgs e)
        {
            if (txtIsım.Text == "")
            {
                txtIsım.Text = "İsminiz";
                txtIsım.ForeColor = Color.Gray;
            }
        }
        private void txtSoyisim_Enter(object sender, EventArgs e)
        {
            if (txtSoyisim.Text == "Soyisminiz")
            {
                txtSoyisim.Text = "";
                txtSoyisim.ForeColor = Color.Black;
            }
        }

        private void txtSoyisim_Leave(object sender, EventArgs e)
        {
            if (txtSoyisim.Text == "")
            {
                txtSoyisim.Text = "Soyisminiz";
                txtSoyisim.ForeColor = Color.Gray;
            }
        }
        private void txtTc_Enter(object sender, EventArgs e)
        {
            if (txtTc.Text == "40000000000")
            {
                txtTc.Text = "";
                txtTc.ForeColor = Color.Black;
            }
        }

        private void txtTc_Leave(object sender, EventArgs e)
        {
            if (txtTc.Text == "")
            {
                txtTc.Text = "40000000000";
                txtTc.ForeColor = Color.Gray;
            }
        }
        private void txtTel_Enter(object sender, EventArgs e)
        {
            if (txtTel.Text == "5001234567")
            {
                txtTel.Text = "";
                txtTel.ForeColor = Color.Black;
            }
        }

        private void txtTel_Leave(object sender, EventArgs e)
        {
            if (txtTel.Text == "")
            {
                txtTel.Text = "5001234567";
                txtTel.ForeColor = Color.Gray;
            }
        }
        #endregion

        private void Register_Load(object sender, EventArgs e)
        {
            #region placeholder
            txtIsım.Text = "İsminiz";
            txtIsım.ForeColor = Color.Gray;
            txtSoyisim.Text = "Soyisminiz";
            txtSoyisim.ForeColor = Color.Gray;
            txtTc.Text = "40000000000";
            txtTc.ForeColor = Color.Gray;
            txtTel.Text = "5001234567";
            txtTel.ForeColor = Color.Gray;
            this.ActiveControl = gönder;
            #endregion
            var list = cityService.GetAll().ToList();
            foreach (var item in list)
            {
                comboBox1.Items.Add(item.Name);
            }

        }

        private void gönder_Click(object sender, EventArgs e)
        {
            string passTc = txtTc.Text.Substring(0, 6);

            string gender = "";
            if (rbErkek.Checked)
            {
                gender = "E";
            }
            else if (rbKadın.Checked)
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
                    Name = txtIsım.Text,
                    Surname = txtSoyisim.Text,
                    IdentificationNumber = txtTc.Text,
                    Phone = txtTel.Text,
                    DateOfBirth = dateTimePicker1.Value,
                    Gender = gender,
                    DateOfRegistration = DateTime.Now.Date,
                    CityId = comboBox1.SelectedIndex + 1,
                    Password = "mhrs" + passTc // "mhrs402734"

                };
                patientService.Create(patient);
                Login login = new Login();
                MessageBox.Show(string.Format("{0} {1} şifreniz {2} \n Değiştirmek için Hesap Bilgilerinize giriniz...", patient.Name, patient.Surname, patient.Password));
                login.sign(patient.IdentificationNumber, patient.Password);

            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }

            this.Close(); //Register Form Kapanır
        }

    }
}
