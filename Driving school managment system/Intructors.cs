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
                    cmd.Parameters.AddWithValue("@Address", txtaddress.Text);
                    cmd.Parameters.AddWithValue("@Status", txtstatus.Text);
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

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from Instructors where Id=@Id", con);
                    cmd.Parameters.AddWithValue("@Id", txtid.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Dleted successfuly");


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
        void clear()
        {
            txtaddress.Clear();
            txtname.Clear();
            txtemail.Clear();
            txtid.Clear();
            txtstatus.Clear();
            
            txtphone.Clear();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Update Instructors set Name=@Name, Email=@Email, Phone=@Phone, Address=@Address,Status=@Status, JoinDate=@JoinDate where Id=@Id", con);
                    cmd.Parameters.AddWithValue("@Name", txtname.Text);
                    cmd.Parameters.AddWithValue("@Email", txtemail.Text);
                    cmd.Parameters.AddWithValue("@Phone", txtphone.Text);
                    cmd.Parameters.AddWithValue("@Address", txtaddress.Text);
                    cmd.Parameters.AddWithValue("@status", txtstatus.Text);
                    cmd.Parameters.AddWithValue("@JoinDate", dtDOB.Value);
                    cmd.Parameters.AddWithValue("@Id", txtid.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated seccessfuly");
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
    }
}
