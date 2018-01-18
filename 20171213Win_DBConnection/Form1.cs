using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20171213Win_DBConnection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query="";
            string connString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\student\Desktop\TMS.accdb; Persist Security Info=False;";
            if (textBox1.Text == "")
            {
                query = @"Select * From telebe";
            }
            else
            {
                query =
  @"Select * From telebe where Adi='" + textBox1.Text + "'";
            }

            OleDbConnection conn = new OleDbConnection(connString);
            OleDbCommand cmd = new OleDbCommand(query, conn);
            DataTable dt = new DataTable();
            conn.Open();
            dt.Load(cmd.ExecuteReader());
            conn.Close();
            dataGridView1.DataSource = dt;
        }
    }
}
