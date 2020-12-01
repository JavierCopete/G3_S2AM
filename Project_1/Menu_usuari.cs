using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tlr_controls;
using TLR_Dades;
using System.Reflection;

namespace Project_1
{
    public partial class Menu_usuari : Form
    {
        public Menu_usuari()
        {
            InitializeComponent();
        }
        public string nom_user;

        DataSet dts;
        string DLL, Form, TextBoto;

        private void tlpButtons_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Menu_usuari_Load(object sender, EventArgs e)
        {
            lblUser.Text = nom_user;
            pnlPrincipal.Hide();

            Dades bbdd = new Dades();
            string query = "select * from Menu";
            dts = bbdd.PortarPerConsulta(query);

            foreach (DataRow dr in dts.Tables[0].Rows)
            {
                DLL = dr["DLL"].ToString();
                Form = dr["Form"].ToString();
                TextBoto = dr["TextBoto"].ToString();
                SW_LLenca btn = new SW_LLenca();

                btn.Text = TextBoto;
                btn.Form = Form;
                btn.DLL = DLL;

                tlpButtons.Controls.Add(btn);

                //query = "select * from users";
                //DataSet dtss = bbdd.PortarPerConsulta(query);
            }            
        }





        //private void btnTaulaSimple_Click(object sender, EventArgs e)
        //{
        //    if (this.pnlPrincipal.Controls.Count > 0)
        //        this.pnlPrincipal.Controls.RemoveAt(0);
        //    pnlPrincipal.Show();
        //    Taula_Simple obj = new Taula_Simple();
        //    obj.TopLevel = false;
        //    obj.Dock = DockStyle.Fill;
        //    this.pnlPrincipal.Controls.Add(obj);
        //    this.pnlPrincipal.Tag = obj;
        //    obj.Show();
        //}

        //private void btnTaulaForanea_Click(object sender, EventArgs e)
        //{
        //    if (this.pnlPrincipal.Controls.Count > 0)
        //        this.pnlPrincipal.Controls.RemoveAt(0);
        //    pnlPrincipal.Show();
        //    Taula_Foranea obj = new Taula_Foranea();
        //    obj.TopLevel = false;
        //    obj.Dock = DockStyle.Fill;
        //    this.pnlPrincipal.Controls.Add(obj);
        //    this.pnlPrincipal.Tag = obj;
        //    obj.Show();
        //}

        //private void btnMenu_Click(object sender, EventArgs e)
        //{
        //    pnlPrincipal.Hide();
        //}

        //private void btnCerca_Click(object sender, EventArgs e)
        //{
        //    if (this.pnlPrincipal.Controls.Count > 0)
        //        this.pnlPrincipal.Controls.RemoveAt(0);
        //    pnlPrincipal.Show();
        //    Taula_Cerca obj = new Taula_Cerca();
        //    obj.TopLevel = false;
        //    obj.Dock = DockStyle.Fill;
        //    this.pnlPrincipal.Controls.Add(obj);
        //    this.pnlPrincipal.Tag = obj; 
        //    obj.Show();
        //}
    }
}
