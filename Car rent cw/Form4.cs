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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Formconfirmpricing f1 = new Formconfirmpricing();
            f1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Formconfirmpricing f1 = new Formconfirmpricing();
            f1.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Formconfirmpricing f1 = new Formconfirmpricing();
            f1.Show();
            this.Hide();
        }

        private void btnpricing_Click(object sender, EventArgs e)
        {
            Formconfirmpricing f2 = new Formconfirmpricing();
            f2.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
            this.Hide();
        }
        public class connect
        {
            public string conn()
            {
                String connstring = @"data source=LAPTOP-CHAMU;initial catalog=car_rent;integrated security=true";
                return connstring;
            }
        }
        private void btnviewchargebenz_Click(object sender, EventArgs e)
        {
            try
            {
                connect co = new connect();
                SqlConnection connobj = new SqlConnection(co.conn());
                connobj.Open();

                string sql = "select vehicle_id,vehicle_bran,charge_per_day,additional_charges_pkm from vehicle where vehicle_id=@vid7";
                SqlCommand sqlCommand = new SqlCommand(sql, connobj);
                sqlCommand.Parameters.AddWithValue("@vid7", txtvid7.Text);

                using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnviewchargeaudi_Click(object sender, EventArgs e)
        {
            try
            {
                connect co = new connect();
                SqlConnection connobj = new SqlConnection(co.conn());
                connobj.Open();

                string sql = "select vehicle_id,vehicle_bran,charge_per_day,additional_charges_pkm from vehicle where vehicle_id=@vid8";
                SqlCommand sqlCommand = new SqlCommand(sql, connobj);
                sqlCommand.Parameters.AddWithValue("@vid8", txtvid8.Text);

                using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnviewchargebmw_Click(object sender, EventArgs e)
        {
            try
            {
                connect co = new connect();
                SqlConnection connobj = new SqlConnection(co.conn());
                connobj.Open();

                string sql = "select vehicle_id,vehicle_bran,charge_per_day,additional_charges_pkm from vehicle where vehicle_id=@vid9";
                SqlCommand sqlCommand = new SqlCommand(sql, connobj);
                sqlCommand.Parameters.AddWithValue("@vid9", txtvid9.Text);

                using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnavailabilitybonz_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime selectdate = dateTimePicker1.Value;
                connect co1 = new connect();
                SqlConnection connobj = new SqlConnection(co1.conn());
                connobj.Open();

                String sql2 = "select vehicle_id,booked_dates from book where booked_dates=@vid1  ";
                SqlCommand sqlCommand = new SqlCommand(sql2, connobj);
                sqlCommand.Parameters.AddWithValue("@vid1", selectdate);

                using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnavailabilityaudi_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime selectdate = dateTimePicker1.Value;
                connect co1 = new connect();
                SqlConnection connobj = new SqlConnection(co1.conn());
                connobj.Open();

                String sql2 = "select vehicle_id,booked_dates from book where booked_dates=@vid1  ";
                SqlCommand sqlCommand = new SqlCommand(sql2, connobj);
                sqlCommand.Parameters.AddWithValue("@vid1", selectdate);

                using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnavailabilitybmw_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime selectdate = dateTimePicker1.Value;
                connect co1 = new connect();
                SqlConnection connobj = new SqlConnection(co1.conn());
                connobj.Open();

                String sql2 = "select vehicle_id,booked_dates from book where booked_dates=@vid1  ";
                SqlCommand sqlCommand = new SqlCommand(sql2, connobj);
                sqlCommand.Parameters.AddWithValue("@vid1", selectdate);

                using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
