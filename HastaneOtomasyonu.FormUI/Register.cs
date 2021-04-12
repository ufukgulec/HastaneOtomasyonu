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
    public partial class Register : Form
    {
        PatientManager PatientManager = new PatientManager(new EfPatientRepository());
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
        private void txtAdres_Enter(object sender, EventArgs e)
        {
            if (txtAdres.Text == "Adresiniz")
            {
                txtAdres.Text = "";
                txtAdres.ForeColor = Color.Black;
            }
        }

        private void txtAdres_Leave(object sender, EventArgs e)
        {
            if (txtAdres.Text == "")
            {
                txtAdres.Text = "Adresiniz";
                txtAdres.ForeColor = Color.Gray;
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
            txtAdres.Text = "Adresiniz";
            txtAdres.ForeColor = Color.Gray;
            this.ActiveControl = gönder;
            #endregion
        }

        private void gönder_Click(object sender, EventArgs e)
        {
            string passTc = txtTc.Text.Substring(0,6);

            string gender = "";
            if (rbErkek.Checked)
            {
                gender = "E";
            }
            else if(rbKadın.Checked)
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
                    name = txtIsım.Text,
                    surname = txtSoyisim.Text,
                    identificationnumber = txtTc.Text,
                    phonenumber = txtTel.Text,
                    dateofbirth = dateTimePicker1.Value,
                    gender = gender,
                    dateofregistration = DateTime.Now.Date,
                    address = txtAdres.Text,
                    password = "mhrs" + passTc // "mhrs402734"

                };
                PatientManager.Create(patient);
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
            
            this.Close(); //Register Form Kapanır
        }
    }
}
