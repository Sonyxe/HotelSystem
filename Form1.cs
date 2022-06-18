using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            DateTime datein = dateIn.Value;
            DateTime dateout = dateOut.Value;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = LAPTOP-UO5LH5O6; database = hotel; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection= con;

            cmd.CommandText = "insert into NewCustomer values (" + id + ", '" + name + "' , '" + room + "','" + datein.ToString() + "','" + dateout.ToString() + "')";

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            txtId.Clear();
            txtName.Clear();
            comboRoom.ResetText();

        }
    }
}
