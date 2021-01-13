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
            }            
        }
    }
}
