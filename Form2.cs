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

namespace BBS
{
    public partial class frmchkavlibility : Form
    {
        public frmchkavlibility()
        {
            InitializeComponent();
        }
        SqlConnection connection;
        SqlCommand command;
        DataTable dbdataset;

        private void frmchkavlibility_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bbs_dbDataSet.newCoustomer_db' table. You can move, or remove it, as needed.
            this.newCoustomer_dbTableAdapter1.Fill(this.bbs_dbDataSet.newCoustomer_db);
        }
            // TODO: This line of code loads data into the 'DataSet1.newCoustomer_db' table. You can move, or remove it, as needed.
          

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dbdataset);
            dv.RowFilter = string.Format("bdate LIKE '%{0}%'", textBox1.Text);
            dataGridView1.DataSource = dv;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection();
            connection.ConnectionString = DBHelper.ConnectionString();
            connection.Open();
            command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "select * from newCoustomer_db";
           
            try {
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = command;
                 dbdataset = new DataTable();

                da.Fill(dbdataset);
                BindingSource bsource = new BindingSource();
                bsource.DataSource = new BindingSource();
                bsource.DataSource = dbdataset;
                dataGridView1.DataSource = bsource;
                da.Update(dbdataset);
            
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
