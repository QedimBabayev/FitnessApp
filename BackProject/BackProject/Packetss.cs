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
    public partial class Packetss : Form

    {

        private readonly FitnessEntities _context;
        private int UpdatedId;

        public Packetss()
        {
            InitializeComponent();
            _context = new FitnessEntities();
        }

    

        private void Packetss_Load(object sender, EventArgs e)
        {
            FillCmbPacket();
            FillDataGriwPackets();
     
        }
       
        private void FillCmbPacket()
        {
            cmbPackets.Items.AddRange(_context.Packets.Select(p => p.PacketName).ToArray());
        }
        private void FillDataGriwPackets()
        {
            dgrPackets.DataSource = _context.Packets.Select(p => new
            {
                p.Id,
                p.PacketName,
                p.PacketPrice,
                p.PacketTime,

            }).ToList();

        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            cmbPackets.Items.Clear();
            dgrPackets.DataSource = "";
            string name = txtNewName.Text;
            decimal price = numPacket.Value;
            string time = txtServiceDuration.Text;

            if(name == "" || price == 0 || time == "")
            {

                MessageBox.Show("Please input  all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }


            Packet newPacket = new Packet();
            newPacket.PacketName = name;
            newPacket.PacketPrice =(decimal) price;
            newPacket.PacketTime = time;
           

            _context.Packets.Add(newPacket);
            _context.SaveChanges();

            FillCmbPacket();
            FillDataGriwPackets();
            txtNewName.Text = txtServiceDuration.Text = "";
            numPacket.Value = 0;
        }

      
        private void DgrPackets_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
        
            int id = (int)dgrPackets.Rows[e.RowIndex].Cells[0].Value;
            UpdatedId = id;
            Packet selectedPacket = new Packet();
            selectedPacket = _context.Packets.Find(id);
            txtNewName.Text = selectedPacket.PacketName;
             numPacket.Value = selectedPacket.PacketPrice;
            txtServiceDuration.Text = selectedPacket.PacketTime;




        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {

            cmbPackets.Items.Clear();
            dgrPackets.DataSource = "";

            string name = txtNewName.Text;
            string time = txtServiceDuration.Text;
            decimal price = numPacket.Value;



            Packet updated = _context.Packets.Find(UpdatedId);
            updated.PacketName = name;
            updated.PacketPrice = price;
            updated.PacketTime = time;
            _context.SaveChanges();
            FillCmbPacket();
            FillDataGriwPackets();
            txtNewName.Text = txtServiceDuration.Text = "";
            numPacket.Value = 0;
         









        }

        private void Button1_Click(object sender, EventArgs e)
        {
            cmbPackets.Items.Clear();
            dgrPackets.DataSource = "";


            Packet deletedPacket = _context.Packets.Find(UpdatedId);
            _context.Packets.Remove(deletedPacket);

            List<CardToPacketService> cardPacket = _context.CardToPacketServices.Where(cmp => cmp.PacketsssId == deletedPacket.Id).ToList();
            foreach (var item in cardPacket)
            {
                _context.CardToPacketServices.Remove(item);
            }
            _context.SaveChanges();
            FillCmbPacket();
            FillDataGriwPackets();

            txtNewName.Text = txtServiceDuration.Text = "";
            numPacket.Value = 0;
        }

        private void PacketsAndServicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PacketsAndServicess packetandservice = new PacketsAndServicess();
            packetandservice.ShowDialog();

        }

        private void ServicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Servicess s = new Servicess();
            s.ShowDialog();
        }

        private void PacketsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Packetss pc = new Packetss();
            pc.ShowDialog();
        }

        private void RegistersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registerss r = new Registerss();
            r.ShowDialog();
        }
    }
}
