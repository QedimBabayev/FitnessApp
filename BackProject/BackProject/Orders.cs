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
    public partial class Orders : Form
    {

        private readonly FitnessEntities _context;
        private int selectedİd;
        private int selectedRegisterId;

        public Orders()
        {
            InitializeComponent();
            _context = new FitnessEntities();

        }

        private void Orders_Load(object sender, EventArgs e)
        {


            FillComboBoxPackets();
            FillDataOrders();
            FillDataGrid();
            FillComboBoxServices();
        }

        private void FillDataOrders()
        {
            dgrOrders.DataSource = _context.CardToPacketServices.Select(cps => new
            {

                cps.Id,
                cps.Card.Register.ClientName,
                cps.Card.Register.ClientSurname,
                cps.Packet,
                cps.Service,
              





            }




           ).ToArray();
        }


        private void FillDataGrid()
        {
            dgrRegister.DataSource = _context.Cards.Select(c => new
            {
                c.Id,
                c.CardNumber,


                c.Register.ClientName,
                c.Register.ClientSurname,




            }).ToArray();
        }
        private void FillComboBoxPackets()
        {
            cmbPacket.Items.AddRange(_context.Packets.Select(p => p.PacketName).ToArray());


        }
        private void FillComboBoxServices()
        {
            cmbService.Items.AddRange(_context.Services.Select(s => s.ServiceNames).ToArray());


        }

        private void DgrOrders_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {


            int id = (int)dgrOrders.Rows[e.RowIndex].Cells[0].Value;
            selectedİd = id;

            CardToPacketService cps = new CardToPacketService();
            cps = _context.CardToPacketServices.Find(id);
            txtClientName.Text = cps.Card.Register.ClientName;
            txtSurname.Text = cps.Card.Register.ClientSurname;
            txtNumber.Text = cps.Card.CardNumber;




        }



        private void DgrRegister_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            int registerId = (int)dgrRegister.Rows[e.RowIndex].Cells[0].Value;

            Card register = new Card();
            register = _context.Cards.Find(registerId);
            selectedRegisterId = registerId;

            txtClientName.Text = register.Register.ClientName;
            txtSurname.Text = register.Register.ClientSurname;
            txtNumber.Text = register.CardNumber;
        }
        private void Button1_Click(object sender, EventArgs e)
        {

            Card selectedRegister = _context.Cards.Find(selectedRegisterId);
            CardToPacketService newCps = _context.CardToPacketServices.Add(new CardToPacketService()
            {

                CardId = selectedRegister.Id,
                PacketsssId = _context.Packets.FirstOrDefault(c => c.PacketName == cmbPacket.Text).Id,
                ServicesssId = null,

            });
            Incoming newIncoming = new Incoming();

            newIncoming.RegisterId = _context.Registers.First(r=>r.ClientName==txtClientName.Text).Id;
            newIncoming.ClientIncomes = (long)_context.Packets.FirstOrDefault(p => p.PacketName == cmbPacket.Text).PacketPrice;
            newIncoming.IncomeMonth = DateTime.Now;

            _context.Incomings.Add(newIncoming);

            _context.SaveChanges();
            FillDataOrders();
            txtNumber.Text = txtSurname.Text = txtClientName.Text = "";


        }

        private void Button2_Click(object sender, EventArgs e)
        {

            Card selectedRegister = _context.Cards.Find(selectedRegisterId);
            CardToPacketService newCps = _context.CardToPacketServices.Add(new CardToPacketService()
            {

                CardId = selectedRegister.Id,
                PacketsssId = null,
                ServicesssId = _context.Services.FirstOrDefault(s => s.ServiceNames == cmbService.Text).Id,

            });


            Incoming incoming = _context.Incomings.Add(new Incoming()
            {

                RegisterId = _context.Registers.First(r => r.ClientName == txtClientName.Text).Id,
               ClientIncomes =Convert.ToInt64(_context.Services.FirstOrDefault(s => s.ServiceNames == cmbService.Text).ServicePrice) ,
                IncomeMonth = DateTime.Now,
            }) ;

            _context.SaveChanges();
            FillDataOrders();
            txtNumber.Text = txtSurname.Text = txtClientName.Text = "";

        }


        private void TxtSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            string name = textBox1.Text.ToLower().Trim();

            dgrOrders.DataSource = _context.CardToPacketServices.Where(cps => cps.Card.Register.ClientName.Contains(name) || cps.Card.Register.ClientSurname.Contains(name)).Select(cps => new
            {


                cps.Id,
                cps.Card.Register.ClientName,
                cps.Card.Register.ClientSurname,
                cps.Packet,
                cps.Service,
              

            }).ToArray();

            if(name == "")
            {

                FillDataOrders();
            }
        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }
    }
}