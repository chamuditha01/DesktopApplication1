using System;
using System.Collections;
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
    public partial class Formconfirmpricing : Form
    {
        public Formconfirmpricing()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Formconfirmpricing_Load(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form7 form8 = new Form7();
            form8.Show();
        }
        public class connect
        {
            public string conn()
            {
                String connstring = @"data source=LAPTOP-CHAMU;initial catalog=car_rent;integrated security=true";
                return connstring;

            }
        }
        private void btnbook_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime selecteddate = dateTimePicker1.Value;
                DateTime selecteddate2 = dateTimePicker2.Value;

                connect co1 = new connect();
                SqlConnection connobj = new SqlConnection(co1.conn());
                connobj.Open();

                String sql1 = "insert into customer values('" + txtcusid.Text + "','" + txtcusname.Text + "','" + txtcusaddress.Text + "')";
                SqlCommand cmd = new SqlCommand(sql1, connobj);
                cmd.ExecuteNonQuery();
                MessageBox.Show("customer added successfully");


                String sql = "insert into book values('" + txtbookingid.Text + "','" + txtcusid.Text + "','" + txtvehicleid.Text + "',@datevalue,@datevalue2)";
                SqlCommand sqlCommand1 = new SqlCommand(sql, connobj);
                sqlCommand1.Parameters.AddWithValue("@DateValue", selecteddate);
                sqlCommand1.Parameters.AddWithValue("@DateValue2", selecteddate2);
                sqlCommand1.ExecuteNonQuery();
                MessageBox.Show("booked successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }



        private void btnview_Click(object sender, EventArgs e)
        {
            int total;
            int km=Convert.ToInt32(txtkm.Text);
            int days=Convert.ToInt32(txtnoofdays.Text);
            int charge;
            int additional;

            String connectionString = @"data source=LAPTOP-CHAMU;initial catalog=car_rent;integrated security=true";
            String query = "SELECT charge_per_day FROM vehicle WHERE vehicle_id='"+txtvehiidpricing.Text+"'";
            String query1= "SELECT additional_charges_pkm FROM vehicle WHERE vehicle_id='" + txtvehiidpricing.Text + "'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query,connection))
                {
                    object result = command.ExecuteScalar();

                     charge=Convert.ToInt32(result);
                }
                using (SqlCommand command = new SqlCommand(query1, connection))
                {
                    object result1 = command.ExecuteScalar();

                    additional = Convert.ToInt32(result1);
                }

                total=(charge*days)+(additional*km);
                label9.Text = total.ToString();

            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime selecteddate3 = dateTimePicker3.Value;
                

                connect co1 = new connect();
                SqlConnection connobj = new SqlConnection(co1.conn());
                connobj.Open();

                


                String sql = "insert into payments values('" + txtpayid.Text + "','" + txtamount.Text + "', @datevalue3 , '" + txtcusid2.Text + "')";
                SqlCommand sqlCommand1 = new SqlCommand(sql, connobj);
                sqlCommand1.Parameters.AddWithValue("@DateValue3", selecteddate3);
                sqlCommand1.ExecuteNonQuery();
                MessageBox.Show("saved successfully");
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}






        
