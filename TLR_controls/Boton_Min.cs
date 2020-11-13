using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO.IsolatedStorage;

namespace Tlr_controls
{
    public partial class Boton_Min : Button
    {
        public Boton_Min()
        {
            InitializeComponent();
        }

        public Boton_Min(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        private void Boton_Min_Click(object sender, EventArgs e)
        {
            Form frm = this.FindForm();
            frm.WindowState = FormWindowState.Minimized;
        }
    }
}
