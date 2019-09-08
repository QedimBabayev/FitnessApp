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
    public partial class Incomess : Form
    {

        private readonly FitnessEntities _context;
        public Incomess()
        {
            InitializeComponent();
            _context = new FitnessEntities();
        }

        private void Incomess_Load(object sender, EventArgs e)
        {
            FillDgrIncomes();
            FillOutcimes();
        }

        private void FillDgrIncomes()
        {
            dgrIncomes.DataSource = _context.Incomings.Select(r => new
            {

                r.Id,
                r.Register.ClientName,
                r.Register.ClientSurname,
                r.ClientIncomes,
                r.IncomeMonth,

            }).ToArray();

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
        private void MonthValueChanged(object sender, EventArgs e)
        {

            txtResultIncome.Text = _context.Incomings.Where(i => dtMonthMin.Value <= i.IncomeMonth  && dtMonthMax.Value >= i.IncomeMonth).Sum(i => i.ClientIncomes).ToString();
            txtTools.Text = _context.Outcomes.Where(o => dtMonthMin.Value <= o.Mont && dtMonthMax.Value >= o.Mont).Sum(o => o.Tools).ToString();
            txtCleaning.Text = _context.Outcomes.Where(o => dtMonthMin.Value <= o.Mont && dtMonthMax.Value >= o.Mont).Sum(o => o.Cleaning).ToString();

            txtTotal.Text = (Convert.ToInt64(txtTools.Text) + Convert.ToInt64(txtCleaning.Text)).ToString() ;

            txtPureIcomes.Text = (Convert.ToInt64(txtResultIncome.Text) - Convert.ToInt64(txtTotal.Text)).ToString();

       }

        private void DtMonthMin_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
