using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BackProject.Model;

namespace BackProject
{
    public partial class Form1 : Form
    {

        private readonly FitnessEntities _context;
        public Form1()
        {
            InitializeComponent();
            _context = new FitnessEntities();   
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckEnable();

        }

        private void NumberClickEventHandler(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if(txtNumber.Text.Length < 4)
            {
                txtNumber.Text += btn.Text;

            }
            CheckEnable();

        }

        private void Button12_Click(object sender, EventArgs e)
        {
            txtNumber.Text = "";
            CheckEnable();
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            
            string password = txtNumber.Text;

            if(password.Length > 0)
            {
                txtNumber.Text = password.Remove(password.Length - 1, 1);

            }

            CheckEnable();

        }

        private void BtnOk_Click(object sender, EventArgs e)
        {


            string passwod = txtNumber.Text;

            AdminParol adminParol = _context.AdminParols.First();

            if(adminParol.AdminParol1 == passwod)
            {

                MainPage mainPage = new MainPage();
                mainPage.ShowDialog();
            }

            else
            {
                MessageBox.Show("Please input a valid password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            CheckEnable();



        }

        private void CheckEnable()
        {
            if (txtNumber.Text.Length == 4)
            {
                btnOk.Enabled = true;
            }
            else
            {
                btnOk.Enabled = false;
            }


        }

        private void BtnUser_Click(object sender, EventArgs e)
        {
            Registerss registerPage = new Registerss();
            registerPage.ShowDialog();

        }
    }
}
