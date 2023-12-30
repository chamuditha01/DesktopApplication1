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

namespace Car_rent_cw
{
   
    public partial class Formsignup : Form
    {
        public Formsignup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Formsignup_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        public class connect
        {
            public string conn()
            {
                String connstring = @"data source=LAPTOP-CHAMU;initial catalog=car_rent;integrated security=true";
                return connstring;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                connect co=new connect();
                SqlConnection connobj=new SqlConnection(co.conn());
                connobj.Open();


                String sql = "insert into owner11 values('"+txtoid.Text+"','"+txtoname.Text+"','"+txtusername.Text+"','"+txtpassward.Text +"')";

                SqlCommand cmd=new SqlCommand(sql, connobj);
                cmd.ExecuteNonQuery();

                Formlogin formlogin = new Formlogin();
                formlogin.Show();
                
                MessageBox.Show("Owner registered successfully");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Formlogin formlogin = new Formlogin();
            formlogin.Show();
            this.Hide();
        }
    }
}
