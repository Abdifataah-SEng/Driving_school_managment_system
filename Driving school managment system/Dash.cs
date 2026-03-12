using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Driving_school_managment_system
{
    public partial class Dash : Form
    {
        public Dash()
        {
            InitializeComponent();
        }
        void moveIt(object sender)
        {
            panel10.Top = ((Button)sender).Top;
            panel10.Height = ((Button)sender).Height;

           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dashbourd_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDash_Click(object sender, EventArgs e)
        {
            moveIt(sender);
            lblform.Text = "Dashboard";
            pnlContianer.Controls.Add(lblform);
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            moveIt(sender);
            lblform.Text = "Student";
            pnlContianer.Controls.Clear();
            uc_Student st = new uc_Student();
            st.Dock = DockStyle.Fill;
            pnlContianer.Controls.Add(st);
        }

        private void btnIntructors_Click(object sender, EventArgs e)
        {
            moveIt(sender);
            lblform.Text = "Intructors";
            pnlContianer.Controls.Clear();
            uc_Intructors in1 = new uc_Intructors();
            in1.Dock = DockStyle.Fill;
            pnlContianer.Controls.Add(in1);
        }

        private void btncourses_Click(object sender, EventArgs e)
        {
            moveIt(sender);
            lblform.Text = "Courses";
        }

        private void btnExrollments_Click(object sender, EventArgs e)
        {
            moveIt(sender);
            lblform.Text = "Exrollments";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pnlContianer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
