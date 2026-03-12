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
using System.Data.Sql;

namespace Driving_school_managment_system
{
    public partial class Intructors : Form

    {
        SqlConnection con = new SqlConnection(@"server=.; Database=Driving; Integrated Security=true;");

        public Intructors()
        {
            InitializeComponent();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {

                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Insert into Instructors (Name,Email,Phone,Address,Status,JoinDate) VALUES (@Name,@Email,@Phone,@Address,@Status,@JoinDate)", con);
                    cmd.Parameters.AddWithValue("@Name", txtname.Text);
                    cmd.Parameters.AddWithValue("@Email", txtemail.Text);
                    cmd.Parameters.AddWithValue("@Phone", txtphone.Text);
                    cmd.Parameters.AddWithValue("@Status", txtstatus);
                    cmd.Parameters.AddWithValue("@Address", txtaddress.Text);
                    cmd.Parameters.AddWithValue("@JoinDate", dtDOB.Value);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("save seccessfuly");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                con.Close(); 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
