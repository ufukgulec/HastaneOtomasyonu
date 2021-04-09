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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            tcNo.Text = "Tc Kimlik No";
            tcNo.ForeColor = Color.Gray;
            parola.Text = "Parola Giriniz";
            parola.ForeColor = Color.Gray;
            this.ActiveControl = giris;

        }
        private void tcNo_Enter(object sender, EventArgs e)
        {
            if (tcNo.Text == "Tc Kimlik No")
            {
                tcNo.Text = "";
                tcNo.ForeColor = Color.Black;
            }
        }

        private void tcNo_Leave(object sender, EventArgs e)
        {
            if (tcNo.Text == "")
            {
                tcNo.Text = "Tc Kimlik No";
                tcNo.ForeColor = Color.Gray;
            }
        }



        private void parola_Enter(object sender, EventArgs e)
        {
            if (parola.Text == "Parola Giriniz")
            {
                parola.Text = "";
                parola.ForeColor = Color.Black;
                parola.PasswordChar = '*';
            }
        }

        private void parola_Leave(object sender, EventArgs e)
        {
            if (parola.Text == "")
            {
                parola.Text = "Parola Giriniz";
                parola.ForeColor = Color.Gray;
                parola.PasswordChar = '\0';
            }
        }
    }
}
