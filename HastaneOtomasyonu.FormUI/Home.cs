﻿using HastaneOtomasyonu.Business;
using HastaneOtomasyonu.Dal.Abstract;
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
using MaterialSkin;
using MaterialSkin.Controls;
namespace HastaneOtomasyonu.FormUI
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login()
            {
                FForm = this
            };

            this.Hide();
            login.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
        }
    }
}
