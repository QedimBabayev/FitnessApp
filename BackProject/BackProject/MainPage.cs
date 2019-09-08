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
    public partial class MainPage : Form
    {

        private readonly FitnessEntities _context;

        public MainPage()
        {
            InitializeComponent();
            _context = new FitnessEntities();


        }

        private void ServicesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Servicess service = new Servicess();
            service.ShowDialog();
        }

        private void RegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registerss rg = new Registerss();
            rg.ShowDialog();
        }

        private void PacketsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Packetss pc = new Packetss();
            pc.ShowDialog();
        }

        private void IncomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Incomess i = new Incomess();
            i.ShowDialog();
        }

        private void OutcomesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Outcomess o = new Outcomess();
            o.ShowDialog();
        }
    }
}
