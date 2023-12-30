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
using static Car_rent_cw.Formsignup;

namespace Car_rent_cw
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
            this.Hide();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }
        public string conn()
        {
            String connstring = @"data source=LAPTOP-CHAMU;initial catalog=car_rent;integrated security=true";
            return connstring;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                connect co = new connect();
                SqlConnection connobj = new SqlConnection(co.conn());
                connobj.Open();

                String sql = "update  vehicle set vehicle_bran='" + txtvehibrand.Text + "', charge_per_day='"+txtcharge.Text+ "', additional_charges_pkm='"+txtadditional.Text+"' where vehicle_id='"+txtvehiid.Text+"'";

                SqlCommand sqlCommand = new SqlCommand(sql, connobj);
                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("vehicle updated successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            try
            {
                 connect co = new connect();
                SqlConnection connobj = new SqlConnection(co.conn());
                connobj.Open();

                String sql1 = "delete from vehicle where vehicle_id='"+txtvehiid2.Text+"'";
                SqlCommand sqlCommand = new SqlCommand( sql1, connobj);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("vehicle removed successfully");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message );
            }
            

        }
    }
}
