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
    public partial class Taula_Simple : TLR_Forms.BaseForm
    {
        public Taula_Simple()
        {
            InitializeComponent();
        }

        private void Taula_Simple_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            TLR_Dades.Dades bbdd = new TLR_Dades.Dades();
            DataSet dts;
            dts = bbdd.PortarTaula(txtTaula.Text);
            dataGridView1.DataSource = dts.Tables[0];

        }
    }
}
