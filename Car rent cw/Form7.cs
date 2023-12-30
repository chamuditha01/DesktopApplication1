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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int type = comborenttype.SelectedIndex;

            if (type == 0)
            {
                Formselect1 f1 = new Formselect1();
                f1.Show();
                this.Hide();
            }
            else if(type==1)
            {
                Form4 form4 = new Form4();
                form4.Show();
                this.Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Formconfirmpricing formconfirmpricing = new Formconfirmpricing();
            formconfirmpricing.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.Show();
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
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                connect co = new connect();
                SqlConnection connobj = new SqlConnection(co.conn());
                connobj.Open();

                string sql = "select * from payments";
                SqlCommand sqlCommand = new SqlCommand(sql, connobj);
                

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
