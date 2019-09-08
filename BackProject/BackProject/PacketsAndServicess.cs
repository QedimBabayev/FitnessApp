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
    public partial class PacketsAndServicess : Form
    {

        private readonly FitnessEntities _context;
     


        public PacketsAndServicess()
        {
            InitializeComponent();
            _context = new FitnessEntities();

        }

        private void PacketsAndServicess_Load(object sender, EventArgs e)
        {
            FillListServices();
            FillCmbPacket();
            FillDataGrid();

        }

        private void FillListServices()
        {
            listServices.Items.AddRange(_context.Services.Select(s => s.ServiceNames).ToArray());

        }
        private void FillCmbPacket()
        {
            cmbPackets.Items.AddRange(_context.Packets.Select(p => p.PacketName).ToArray());



        }





        private void FillDataGrid()
        {

            dgrPacketsToServices.DataSource = _context.PacketToServies.Select(c => new
            {
                c.Id,
                c.Packet.PacketName,
                c.Packet.PacketPrice,


                c.Service.ServiceNames,
                c.Service.ServicePrice,

            }).ToList();
        }


        private void ListServices_SelectedIndexChanged(object sender, EventArgs e)
        {

            //string name = listServices.SelectedItem.ToString();
            //int id = _context.Services.FirstOrDefault(s => s.ServiceNames == name).Id;
            //label2.Text = id.ToString();
            //listServices.SelectedItems

            //PacketToServy packetToServy = new PacketToServy();
            //packetToServy.PacketsId = id;
            //packetToServy.ServiceId = cmbPackets.
            



        }
     

        private void Button1_Click(object sender, EventArgs e)
        {
            
                string name = cmbPackets.SelectedItem.ToString();
          

           
            foreach (string nameServices in listServices.CheckedItems)
            {
            int idservice = _context.Services.First(s => s.ServiceNames == nameServices).Id;
                int id = _context.Packets.FirstOrDefault(p => p.PacketName == name).Id;



                PacketToServy packetToServy = new PacketToServy();

                     

                packetToServy.PacketsId = id;
                                packetToServy.ServiceId = idservice;
                                _context.PacketToServies.Add(packetToServy);
                
               


            }


            //string nameservice = listServices.SelectedItems.ToString();




            
            _context.SaveChanges();
            FillDataGrid();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string name = cmbPackets.Text;
            int id = _context.Packets.FirstOrDefault(p => p.PacketName == name).Id;

            foreach (string nameServices in listServices.CheckedItems)
            {
                int idservice = _context.Services.First(s => s.ServiceNames == nameServices).Id;


                PacketToServy selectedService = _context.PacketToServies.FirstOrDefault(pts => pts.PacketsId == id && pts.ServiceId == idservice);
                _context.PacketToServies.Remove(selectedService);
               
            };
            _context.SaveChanges();


            FillDataGrid();
        }

        private void RegistersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registerss r = new Registerss();
            r.ShowDialog();
        }

        private void ServicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Servicess s = new Servicess();
            s.ShowDialog();
        }

        private void PacketsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Packetss p = new Packetss();
            p.ShowDialog();
        }

        private void PacketsAndServicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PacketsAndServicess ps = new PacketsAndServicess();
            ps.ShowDialog();
        }
    }
}
