using HastaneOtomasyonu.Business;
using HastaneOtomasyonu.Business.Abstract;
using HastaneOtomasyonu.Dal.Concrete.EntityFramework.Repository;
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
    public partial class LoginPage : MaterialForm
    {
        public Form form;
        IPatientService patientService = new PatientManager(new EfPatientRepository());
        public LoginPage()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Red800, Primary.Red900, Primary.Red500, Accent.Red200, TextShade.WHITE);
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }



        private void btnRegis_Click(object sender, EventArgs e)
        {
            RegisterPage registerPage = new RegisterPage()
            {
                form = form
            };
            this.Close();
            registerPage.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string ID = txtId.Text;
            string Password = txtPassword.Text;
            sign(ID, Password);
        }
        public void sign(string Id, string Password)
        {
            var patient = patientService.Login(Id, Password);
            if (patient != null)
            {
                PanelPage panel = new PanelPage()
                {
                    patient = patient,
                    form = this
                };
                this.Hide();
                panel.ShowDialog();

            }
            else
            {
                MessageBox.Show("Hatalı Tc veya Şifre");
            }
        }

        private void LoginPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.Show();
        }
    }
}
