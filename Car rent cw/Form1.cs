using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_rent_cw
{
    public partial class Formlogin : Form
    {
        public Formlogin()
        {
            InitializeComponent();
        }

        private void button1_Enter(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Formsignup ff=new Formsignup();
            ff.Show();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                String username = txtusername.Text;
                String passward = txtpassward.Text;
                string pass;

                String connectionString = @"data source=LAPTOP-CHAMU;initial catalog=car_rent;integrated security=true";
                String query = "SELECT passward FROM owner11 WHERE username='" + txtusername.Text + "'";


                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        object result = command.ExecuteScalar();

                        pass = Convert.ToString(result);
                        if(txtusername.Text != String.Empty && txtpassward.Text != String.Empty)
                        {
                           if(pass==passward)
                            {
                                Form7 form7 = new Form7();
                                form7.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("wrong username or passward! please re-enter");
                            }
                        }
                        else
                        {
                            MessageBox.Show("please fill logins");
                        }
                    


                    
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form9 form=new Form9();
            form.Show();
        }

        private void txtusername_Validating(object sender, CancelEventArgs e)
        {
           
            
        }
    }
}
