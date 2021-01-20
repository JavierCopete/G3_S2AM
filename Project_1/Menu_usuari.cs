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
        public string idUser;

        DataSet dts;
        string DLL, Form, TextBoto, AccessLevel;

        private void Menu_usuari_Load(object sender, EventArgs e)
        {
            lblUser.Text = nom_user;

            Dades bbdd = new Dades();
            string query = "select * from Menu";
            dts = bbdd.PortarPerConsulta(query);

            string queryAcces = "select AccessLevel from UserCategories, Users " +
                "where Users.idUserCategory = UserCategories.idUserCategory and idUser = '" + idUser + "'";
            DataSet dtsnivell = bbdd.PortarPerConsulta(queryAcces);
            string nivell = idUser = dtsnivell.Tables[0].Rows[0][0].ToString();

            foreach (DataRow dr in dts.Tables[0].Rows)
            {
                DLL = dr["DLL"].ToString();
                Form = dr["Form"].ToString();
                TextBoto = dr["TextBoto"].ToString();
                AccessLevel = dr["AccessLevel"].ToString();
                
                if(int.Parse(AccessLevel) <= int.Parse(nivell))
                {
                    SW_LLenca btn = new SW_LLenca();

                    btn.Text = TextBoto;
                    btn.Form = Form;
                    btn.DLL = DLL;

                    tlpButtons.Controls.Add(btn);
                }   
            }            
        }
    }
}
