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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Biblioteca_Dades.Dades cls = new Biblioteca_Dades.Dades();

            String nom_taula = txtTaula.Text;
            DataSet dts = cls.PortarTaula(nom_taula);
            dataGridView1.DataSource = dts.Tables[0];
            
        }
    }
}
