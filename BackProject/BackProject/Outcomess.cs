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
    public partial class Outcomess : Form
    {

        private readonly FitnessEntities _context;
        private int SelectedOutcomeId;
        public Outcomess()
        {
            InitializeComponent();
            _context = new FitnessEntities();
        }

        private void Outcomess_Load(object sender, EventArgs e)
        {
            FillOutcimes();
            FillCmbServices();

        }
        private void FillOutcimes()
        {
            dgrOutcomes.DataSource = _context.Outcomes.Select(o => new
            {
                o.Id,
                o.Cleaning,
                o.Tools,
                o.Service.ServiceNames,
                o.Mont,
            }).ToArray();
        }

        private void FillCmbServices()
        {
            cmbServices.Items.AddRange(_context.Services.Select(s => s.ServiceNames).ToArray());
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            Outcome outcome = _context.Outcomes.Add(new Outcome()
            {
                Tools = Convert.ToInt64(txtTools.Text) ,
                Cleaning = Convert.ToInt64(txtClean.Text),
                WhichService = _context.Services.FirstOrDefault(s => s.ServiceNames == cmbServices.Text).Id,
                Mont = DateTime.Now
            });
            _context.SaveChanges();
            FillOutcimes();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            Outcome outcome = _context.Outcomes.Find(SelectedOutcomeId);
            outcome.Cleaning = Convert.ToInt64(txtClean.Text);
            outcome.Tools = Convert.ToInt64(txtTools.Text);
            outcome.WhichService = _context.Services.First(s => s.ServiceNames == cmbServices.Text).Id;
            _context.SaveChanges();
            FillOutcimes();

        }

        private void DgrOutcomes_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int outcomeId = (int)dgrOutcomes.Rows[e.RowIndex].Cells[0].Value;
            SelectedOutcomeId = outcomeId;

            Outcome SelectedOutcome = _context.Outcomes.Find(outcomeId);
            cmbServices.Text = SelectedOutcome.Service.ServiceNames;
            txtClean.Text = SelectedOutcome.Cleaning.ToString();
            txtTools.Text = SelectedOutcome.Tools.ToString();

        }
    }
}
