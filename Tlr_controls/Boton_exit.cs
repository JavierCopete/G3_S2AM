using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data;

namespace Tlr_controls
{
    public partial class Boton_exit : Button
    {
        public Boton_exit()
        {
            InitializeComponent();
        }

        public Boton_exit(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        private void Boton_exit_Click(object sender, EventArgs e)
        {
            Form frm = this.FindForm();
            frm.Close();
        }
    }
}
