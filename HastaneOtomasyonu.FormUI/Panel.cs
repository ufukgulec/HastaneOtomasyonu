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
            #region Load
            btnPatient.Text = patient.name + " " + patient.surname;
            txtisim.Text = patient.name;
            txtsoyisim.Text = patient.surname;
            txtadres.Text = patient.address;
            txtTc.Text = patient.identificationnumber;
            txtparola.Text = patient.password;
            txttel.Text = patient.phonenumber;
            dateTimePicker1.Value = (DateTime)patient.dateofbirth;

            GenericManager<City> cityManager = new GenericManager<City>(new EfGenericRepository<City>());
            foreach (var item in cityManager.GetAll().ToList())
            {
                comboBox1.Items.Add(item.name);
            }
            #endregion

        }
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
