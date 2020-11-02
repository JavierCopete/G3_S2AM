using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }
        private void progressBar1_Click(object sender, EventArgs e)
        {
            progressBar1.ForeColor = Color.Orange;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                this.Hide();
                Log_in obj = new Log_in();
                obj.Show();
            }
        }
    }
}
