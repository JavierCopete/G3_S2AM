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
            pnlPrincipal.Hide();
        }

        private void btnTaulaSimple_Click(object sender, EventArgs e)
        {
            if (this.pnlPrincipal.Controls.Count > 0)
                this.pnlPrincipal.Controls.RemoveAt(0);
            pnlPrincipal.Show();
            Taula_Simple obj = new Taula_Simple();
            obj.TopLevel = false;
            obj.Dock = DockStyle.Fill;
            this.pnlPrincipal.Controls.Add(obj);
            this.pnlPrincipal.Tag = obj;
            obj.Show();
        }

        private void btnTaulaForanea_Click(object sender, EventArgs e)
        {
            if (this.pnlPrincipal.Controls.Count > 0)
                this.pnlPrincipal.Controls.RemoveAt(0);
            pnlPrincipal.Show();
            Taula_Foranea obj = new Taula_Foranea();
            obj.TopLevel = false;
            obj.Dock = DockStyle.Fill;
            this.pnlPrincipal.Controls.Add(obj);
            this.pnlPrincipal.Tag = obj;
            obj.Show();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            pnlPrincipal.Hide();
        }

        private void btnCerca_Click(object sender, EventArgs e)
        {
            if (this.pnlPrincipal.Controls.Count > 0)
                this.pnlPrincipal.Controls.RemoveAt(0);
            pnlPrincipal.Show();
            Taula_Cerca obj = new Taula_Cerca();
            obj.TopLevel = false;
            obj.Dock = DockStyle.Fill;
            this.pnlPrincipal.Controls.Add(obj);
            this.pnlPrincipal.Tag = obj;
            obj.Show();
        }
    }
}
