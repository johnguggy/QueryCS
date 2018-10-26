using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;

namespace QueryCS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SelectData(string selectCommandText)
        {
            try
            {
                //Change the connection string
                //to match with your system
                string selectConnection =
                    @"Data Source = LAPTOP-KC2D2QOU\SQLEXPRESS; Initial Catalog = Northwind; Integrated Security = True";
;
                SqlDataAdapter DataAdapter = new SqlDataAdapter(selectCommandText, selectConnection);
                DataTable table = new DataTable();
                DataAdapter.Fill(table);
                dataGridView1.DataSource = table;                     
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 0)
            {
                SelectData(textBox1.Text);
            }
        }

    }
}
