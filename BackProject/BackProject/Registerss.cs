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
    public partial class Registerss : Form
    {

        private readonly FitnessEntities _context;
        private int UpdatedId;
        public Registerss()
        {
            InitializeComponent();
            _context = new FitnessEntities();
        }

        private void Registerss_Load(object sender, EventArgs e)
        {
            FillDataGrid();
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

        private void BtnAdd_Click(object sender, EventArgs e)
        {

            dgrRegister.DataSource = "";

            string name = txtClientName.Text;
            string surname = txtSurname.Text;
            string cardId = txtCardId.Text;




            if (name == "" || surname == "" || cardId == "")
            {

                MessageBox.Show("Please input all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Register newClient = new Register();
            newClient.ClientName = name;
            newClient.ClientSurname = surname;
           
            _context.Registers.Add(newClient);
            _context.SaveChanges();

            int id = _context.Registers.FirstOrDefault(n => n.ClientName == name && n.ClientSurname == surname).Id;

            Card newCard = new Card();
            newCard.ClientId = id;
            if(_context.Cards.Any(c=>c.CardNumber == cardId))
            {
                MessageBox.Show("CardNumber must be unique", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(cardId.Length < 5)
            {

                MessageBox.Show("CardNumber must be greater than 5 or equal 5", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            newCard.CardNumber = cardId;
            _context.Cards.Add(newCard);
            _context.SaveChanges();

            FillDataGrid();


        }

      

       

 
      


        private void DgrRegister_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            int id = (int)dgrRegister.Rows[e.RowIndex].Cells[0].Value;
            UpdatedId = id;


            Card selectedCard = new Card();
             selectedCard = _context.Cards.Find(id);
            txtCardId.Text = selectedCard.CardNumber;
            txtClientName.Text = selectedCard.Register.ClientName;
            txtSurname.Text = selectedCard.Register.ClientSurname;

        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {

            dgrRegister.DataSource = "";

            string name = txtClientName.Text;
            string surname = txtSurname.Text;
            string cardId = txtCardId.Text;

            Card updatedCard = new Card();
            updatedCard = _context.Cards.Find(UpdatedId);

            if (_context.Cards.Any(c => c.CardNumber == cardId))
            {
                MessageBox.Show("CardNumber must be unique", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cardId.Length < 5)
            {

                MessageBox.Show("CardNumber must be greater than 5 or equal 5", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            updatedCard.CardNumber = cardId;
            updatedCard.Register.ClientName = name;
            updatedCard.Register.ClientSurname = surname;


            _context.SaveChanges();
            FillDataGrid();
            txtClientName.Text = txtSurname.Text = txtCardId.Text = "";

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            dgrRegister.DataSource = "";
            Card deletedCard = _context.Cards.Find(UpdatedId);

            List<CardToPacketService> cardPacket = _context.CardToPacketServices.Where(cmp => cmp.CardId == deletedCard.Id).ToList();
            foreach (var item in cardPacket)
            {
                _context.CardToPacketServices.Remove(item);
            }
            _context.Cards.Remove(deletedCard);
            _context.SaveChanges();

            FillDataGrid();
            txtClientName.Text = txtSurname.Text = txtCardId.Text = "";

        }

        private void OrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Orders newOrder = new Orders();
            newOrder.ShowDialog();
        }

      
    }
}
