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
    public partial class Formselect1 : Form
    {
        public Formselect1()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Formselect2 f2 = new Formselect2();
            f2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Formconfirmpricing f1 = new Formconfirmpricing();
            f1.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Formconfirmpricing f1 = new Formconfirmpricing();
            f1.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Formconfirmpricing f1 = new Formconfirmpricing();
            f1.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form7 f2 = new Form7();
            f2.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Formselect2 formselect2 = new Formselect2();
            formselect2.Show();
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
        private void btnviewchargesalto_Click(object sender, EventArgs e)
        {
            try
            {
                connect co = new connect();
                SqlConnection connobj = new SqlConnection(co.conn());
                connobj.Open();

                string sql = "select vehicle_id,vehicle_bran,charge_per_day,additional_charges_pkm from vehicle where vehicle_id=@vid";
                SqlCommand sqlCommand = new SqlCommand(sql, connobj);
                sqlCommand.Parameters.AddWithValue("@vid",txtvid1.Text);

                using(SqlDataAdapter adapter=new SqlDataAdapter(sqlCommand))
                {
                    DataTable dt=new DataTable ();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void Formselect1_Load(object sender, EventArgs e)
        {

        }

        private void btnviewchargesjalto_Click(object sender, EventArgs e)
        {
            connect co1 = new connect();
            SqlConnection connobj = new SqlConnection(co1.conn());
            connobj.Open();

            string sql1 = "select vehicle_id,vehicle_bran,charge_per_day,additional_charges_pkm from vehicle where vehicle_id=@vid2";
            SqlCommand sqlCommand1 = new SqlCommand(sql1, connobj);
            sqlCommand1.Parameters.AddWithValue("@vid2", txtvid2.Text);

            using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand1))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }

        private void btnviewchargeprius_Click(object sender, EventArgs e)
        {
            
            connect co1 = new connect();
            SqlConnection connobj = new SqlConnection(co1.conn());
            connobj.Open();

            string sql1 = "select vehicle_id,vehicle_bran,charge_per_day,additional_charges_pkm from vehicle where vehicle_id=@vid3";
            SqlCommand sqlCommand1 = new SqlCommand(sql1, connobj);
            sqlCommand1.Parameters.AddWithValue("@vid3", txtvid3.Text);

            using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand1))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }

        private void btnavailabilityalto_Click(object sender, EventArgs e)
        {
            try
            {
                 DateTime selectdate = dateTimePicker1.Value;
                connect co1 = new connect();
                SqlConnection connobj = new SqlConnection(co1.conn());
                connobj.Open();

                String sql2 = "select vehicle_id,booked_dates from book where booked_dates=@vid1  ";
                SqlCommand sqlCommand = new SqlCommand(sql2, connobj);
                sqlCommand.Parameters.AddWithValue("@vid1",selectdate);

                using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnavailabilityjalto_Click(object sender, EventArgs e)
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

        private void btnavailabilityprius_Click(object sender, EventArgs e)
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
