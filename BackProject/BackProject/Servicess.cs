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
    public partial class Servicess : Form
    {

        private readonly FitnessEntities _context;
        private int UpdatedId;
        public Servicess()
        {
            InitializeComponent();
            _context = new FitnessEntities();
        }

        private void Servicess_Load(object sender, EventArgs e)
        {
            FillCmbServices();
            FillDataGrid();
        }

        private void FillDataGrid()
        {

            dgrServices.DataSource = _context.Services.Select(s => new
            {
                s.Id,
                s.ServiceNames,
                s.ServicePrice,
                s.ServiceDuration,

            }).ToList();





        }

        private void FillCmbServices()
        {
            cmbServices.Items.AddRange(_context.Services.Select(s=> s.ServiceNames).ToArray());
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {

            cmbServices.Items.Clear();
            string name = txtNewName.Text;
            string price = txtPrice.Text;
            string duration = txtServiceDuration.Text;
            if(name == "" || price == "" || duration == "")
            {
                MessageBox.Show("Please, input all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Service newService = new Service();
            newService.ServiceNames = name;
            newService.ServicePrice = price;
            newService.ServiceDuration = duration;
            _context.Services.Add(newService);
            _context.SaveChanges();
            FillCmbServices();
            FillDataGrid();
            txtNewName.Text = txtPrice.Text = txtServiceDuration.Text = "";
        }

        private void DgrServices_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            int id = (int)dgrServices.Rows[e.RowIndex].Cells[0].Value;
            UpdatedId = id;

            Service selectedService = new Service();

            selectedService = _context.Services.Find(id);

            txtNewName.Text = selectedService.ServiceNames;
            txtPrice.Text = selectedService.ServicePrice;
            txtServiceDuration.Text = selectedService.ServiceDuration;




        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            string name = txtNewName.Text;
            string price = txtPrice.Text;
            string duration = txtServiceDuration.Text;

            if(name == "" || price == "" || duration == "")
            {

                MessageBox.Show("Please input all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Service updatedService = new Service();
            updatedService = _context.Services.Find(UpdatedId);

            updatedService.ServiceNames = name;
            updatedService.ServiceDuration = duration;
            updatedService.ServicePrice = price;

            _context.SaveChanges();
            FillDataGrid();
            txtNewName.Text = txtPrice.Text = txtServiceDuration.Text = "";



        }

        private void Button1_Click(object sender, EventArgs e)
        {

            cmbServices.Items.Clear();
            Service selectedService = new Service();
            selectedService = _context.Services.Find(UpdatedId);
            List<CardToPacketService> cardPacket = _context.CardToPacketServices.Where(cmp => cmp.ServicesssId == selectedService.Id).ToList();
            foreach (var item in cardPacket)
            {
                _context.CardToPacketServices.Remove(item);
            }

            _context.Services.Remove(selectedService);
            _context.SaveChanges();

            FillDataGrid();
            FillCmbServices();

            txtNewName.Text = txtPrice.Text = txtServiceDuration.Text = "";
        }

        private void PacketsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Packetss packet = new Packetss();
            packet.ShowDialog();

            

        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void PacketAndServicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PacketsAndServicess pcs = new PacketsAndServicess();
            pcs.ShowDialog();
        }

        private void RegistersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registerss r = new Registerss();
            r.ShowDialog();
        }
    }
}
