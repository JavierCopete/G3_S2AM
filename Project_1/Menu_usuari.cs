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
    public partial class Menu_usuari : Form
    {
        public Menu_usuari()
        {
            InitializeComponent();
        }
        public string nom_user;
        private void Menu_usuari_Load(object sender, EventArgs e)
        {
            label2.Text = nom_user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Taula_Simple obj = new Taula_Simple();
            obj.Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Taula_Cerca obj = new Taula_Cerca();
            obj.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            return;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Taula_foranea obj = new Taula_foranea();
            obj.Show();

        }
    }
}
