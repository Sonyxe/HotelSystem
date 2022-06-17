using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible=false;
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String name = txtName.Text;
            String room = comboRoom.Text;
            int id = Convert.ToInt32(txtId.Text);
            int checkin = Convert.ToInt32(dateIn.Text);
            int checkout = Convert.ToInt32(dateOut.Text);


        }
    }
}
