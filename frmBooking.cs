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
using System.Data;


namespace BBS
{
    public partial class frmBooking : Form
    {
        public frmBooking()
        {
            InitializeComponent();
        }
        SqlConnection connection;
        SqlCommand command;
       

        private void frmBooking_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'newCoustomer_dbDataSet1.newCoustomer_db' table. You can move, or remove it, as needed.
            //this.newCoustomer_dbTableAdapter1.Fill(this.newCoustomer_dbDataSet1.newCoustomer_db);
            // TODO: This line of code loads data into the 'newCoustomer_dbDataSet.newCoustomer_db' table. You can move, or remove it, as needed.
            //this.newCoustomer_dbTableAdapter.Fill(this.newCoustomer_dbDataSet.newCoustomer_db);
           
            NextCodeGenerator();
            this.txtAdress.Clear();
            this.txtGuest.Clear();
            this.txtName.Clear();
            this.txtPhone.Clear();
            this.txtPerHead.Clear();
            

           
            
            //string[] functions = { "Mehndi", "Baraat", "Valeema" };
            //int[] partion = { 1, 2 };
            
            //colFunctions.DisplayMember = "functions";
            //colFunctions.DataSource = ds.Tables[0];
            connection.Close();

        }

      

        private void tsbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection();
                connection.ConnectionString = DBHelper.ConnectionString();
                connection.Open();
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "insert into newCoustomer_db values('" + this.txtCode.Text + "','" + this.txtName.Text + "','" + this.txtPhone.Text + "','" + this.txtAdress.Text + "','" + this.dateTimePicker1.Text + "','" + this.txtGuest.Text + "');";
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();
                MessageBox.Show("Category Saved Successfully");
                NextCodeGenerator();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            } 
        }
         public void Multiply()
        {
            int a, b;

            bool isAValid = int.TryParse(txtPerHead.Text, out a);
            bool isBValid = int.TryParse(txtGuest.Text, out b);

            if (isAValid && isBValid)
                txtPayment.Text = (a * b).ToString();

            else
                txtPayment.Text = "Invalid input";
        }
         public void Remaining()
         {
             int c, d,e,f;
             
            
             bool isCValid = int.TryParse(txtPayment.Text, out c);
             bool isDValid = int.TryParse(txtAdvance.Text, out d);
             bool isEValid = int.TryParse(txtDiscount.Text,out e);
             f = c - d - e;
             if (isCValid && isDValid)
                 txtRemaining.Text =f.ToString();
                

             else
                 txtRemaining.Text = "Invalid OutPut";
         }
      

        private void tsbSave_Click(object sender, EventArgs e)
         {
             connection = new SqlConnection(DBHelper.ConnectionString());
             connection.Open();
             SqlTransaction trans = connection.BeginTransaction();
             try
             {

                 command = new SqlCommand();
                 command.Transaction = trans;
                 command.CommandText = "insert into newCoustomer_db(code,name,phone,adress,bdate,guest,perhead,payment,discount,advance,remaining) values('" + this.txtCode.Text + "','" + this.txtName.Text + "','" + this.txtPhone.Text + "','" + this.txtAdress.Text + "','" + this.dateTimePicker1.Text + "','" + this.txtGuest.Text + "','" + this.txtPerHead.Text + "','" + this.txtPayment.Text + "','" + this.txtDiscount.Text + "','" + this.txtAdvance.Text + "','" + this.txtRemaining.Text + "')";
                 command.CommandType = CommandType.Text;
                 command.Connection = connection;
                 command.ExecuteNonQuery();

                 for (int i = 0; i <= dgvFunctionsDetails.Rows.Count - 1; i++)
                 {
                     string functions = dgvFunctionsDetails.Rows[i].Cells[0].Value.ToString();
                     string dates = dgvFunctionsDetails.Rows[i].Cells[1].Value.ToString();
                     string partion = dgvFunctionsDetails.Rows[i].Cells[2].Value.ToString();
                     string code = dgvFunctionsDetails.Rows[i].Cells[3].ToString();



                     command.CommandText = "insert into functions_db values('" + colFunctions + "','" + date + "','" + colPartions.Selected + "','" + code + "')";
                     command.Connection = connection;
                     command.CommandType = CommandType.Text;
                     command.ExecuteNonQuery();

                 }
                 trans.Commit();
                 MessageBox.Show("saved");

             }
             catch (Exception)
             {
                 MessageBox.Show("not saved error");
             }
             finally
             {
                 connection.Close();
             }
         }
            private void NextCodeGenerator()
        {
            connection = new SqlConnection();
            connection.ConnectionString = DBHelper.ConnectionString();
            connection.Open();
            command = new SqlCommand();
            command.CommandText = "select max(code)+1 as nextCode from newCoustomer_db;";
            command.Connection = connection;
            command.CommandType=CommandType.Text;
            object obj = command.ExecuteScalar();
           
            int nextCode= (obj == DBNull.Value) ? 1 : Convert.ToInt32(obj);
            this.txtCode.Text = nextCode.ToString("0000");
        }
            DataSet ds = new DataSet();

            private void DisplayAllCategories()
            {
                connection = new SqlConnection();
                connection.ConnectionString = DBHelper.ConnectionString();
                connection.Open();
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "select * from newCoustomer_db";
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = command;
                ds = new DataSet();
                da.Fill(ds);
                this.lbxCoustomerView.DataSource = null;
                this.lbxCoustomerView.DisplayMember = "Name";
                this.lbxCoustomerView.ValueMember = "Code";
                this.lbxCoustomerView.ValueMember = "Date";
                this.lbxCoustomerView.DataSource = ds.Tables[0];
                connection.Close();
            }

            private void lbxCoustomerView_SelectedIndexChanged(object sender, EventArgs e)
            {
                object obj = this.lbxCoustomerView.SelectedValue;
                MessageBox.Show(obj.ToString());
            }

        

           

            private void txtPayment_TextChanged(object sender, EventArgs e)
            {
                Multiply();
            }

            private void txtGuest_TextChanged(object sender, EventArgs e)
            {
                Multiply();
            }

            private void btnSave_Click_2(object sender, EventArgs e)
            {
               
                try
                {
                    connection = new SqlConnection(DBHelper.ConnectionString());
                    connection.Open();
                    SqlTransaction trans = connection.BeginTransaction();
                    
                    command = new SqlCommand();
                    command.Transaction = trans;
                    command.CommandText = "insert into newCoustomer_db(code,name,phone,adress,bdate,guest,perhead,payment,discount,advance,remaining) values('" + this.txtCode.Text + "','" + this.txtName.Text + "','" + this.txtPhone.Text + "','" + this.txtAdress.Text + "','" + this.dateTimePicker1.Text + "','" + this.txtGuest.Text + "','" + this.txtPerHead.Text + "','" + this.txtPayment.Text + "','" + this.txtDiscount.Text + "','" + this.txtAdvance.Text + "','"+this.txtRemaining.Text+ "')";
                    command.CommandType = CommandType.Text;
                    command.Connection = connection;
                    command.ExecuteNonQuery();
                    
                    for (int i = 0; i < this.dgvFunctionsDetails.Rows.Count - 1; i++)
                    {

                        int functions = ((dgvFunctionsDetails.Rows[i].Cells[0].Value.ToString().StartsWith("M")) ? 1 : 2);
                        string dates = dgvFunctionsDetails.Rows[i].Cells[1].Value.ToString();
                        int partion = ((dgvFunctionsDetails.Rows[i].Cells[2].Value.ToString().StartsWith("1")) ? 1 : 2);
                        string code = dgvFunctionsDetails.Rows[i].Cells[3].ToString();
                        command.CommandText = "insert into functions_db (functions,dates,partion,code) values("+functions+",'"+dates+"','"+partion+"','"+this.txtCode.Text+"')";
                        command.ExecuteNonQuery();
                        MessageBox.Show("saved");
                    }
                    trans.Commit();
                    

                }
                catch (Exception)
                {
                    MessageBox.Show("not saved error");
                }
                finally {
                    connection.Close();
                }
            }

           
            
            private void tsbNew_Click(object sender, EventArgs e)
            {
                NextCodeGenerator();
                this.txtAdress.Clear();
                this.txtGuest.Clear();
                this.txtName.Clear();
                this.txtPhone.Clear();
                this.txtPerHead.Clear();
                
                
            }

           

            private void btnCalculatePayment_Click(object sender, EventArgs e)
            {
                Multiply();
                Remaining();
            }

            public void lbxCoustomerView_SelectedIndexChanged_1(object sender, EventArgs e)
            {

                int currentIndex = this.lbxCoustomerView.SelectedIndex;
                if (currentIndex == -1)
                    return;
                DataRow row = ds.Tables[0].Rows[currentIndex];
                this.txtCode.Text = row[0].ToString();
                this.txtName.Text = row[1].ToString();
                this.txtPhone.Text = row[2].ToString();
                this.txtAdress.Text = row[3].ToString();
                this.dateTimePicker1.Text = row[4].ToString();
                this.txtGuest.Text = row[5].ToString();
                this.txtPerHead.Text = row[6].ToString();
           
            }

            private void tsbDelete_Click(object sender, EventArgs e)
            {
                connection = new SqlConnection();
                connection.ConnectionString = DBHelper.ConnectionString();
                connection.Open();
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "delete from newCoustomer_db where code='" + this.txtCode.Text + "';";
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();
                connection = new SqlConnection();
                connection.ConnectionString = DBHelper.ConnectionString();
                connection.Open();
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "delete from functions_db where code='" + this.txtCode.Text + "';";
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();

                MessageBox.Show("Deleted Successfully");
                connection.Close();
                NextCodeGenerator();
                DisplayAllCategories();
            }


            private void btndashboard_Click(object sender, EventArgs e)
            {
                this.Hide();
                frmDashBoard fd = new frmDashBoard();
                fd.Show();
            }

            private void fillByToolStripButton_Click(object sender, EventArgs e)
            {
                try
                {
                    this.newCoustomer_dbTableAdapter.FillBy(this.newCoustomer_dbDataSet.newCoustomer_db);
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }

            }

            private void tsbView_Click(object sender, EventArgs e)
            {
                DisplayAllCategories();
            }

            private void tabPage1_Click(object sender, EventArgs e)
            {

            }

            
        }
    }