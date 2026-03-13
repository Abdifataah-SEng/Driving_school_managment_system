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
    public partial class uc_Intructors : UserControl
    {
        public uc_Intructors()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          


        }

        private void uc_Intructors_Load(object sender, EventArgs e)
        {
            this.instructorsTableAdapter.Fill(this.drivingDataSet2.Instructors);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Dash dash = new Dash();
            dash.WindowState = FormWindowState.Minimized;
            new PopupEffect.transparentBg(new Intructors());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.instructorsTableAdapter.Fill(this.drivingDataSet2.Instructors);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.instructorsTableAdapter.Fill(this.drivingDataSet2.Instructors);
        }
    }
}
