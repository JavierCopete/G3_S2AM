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

namespace TLR_Forms
{
    public partial class BaseTaulaSimple : BaseForm
    {
        public BaseTaulaSimple()
        {
            InitializeComponent();
        }

        private DataTable infotaula;
        private DataRow dr;
        private DataSet dts;
        private Boolean flag;

        private void BaseTaulaSimple_Load(object sender, EventArgs e)
        {
            
            Dades bbdd = new Dades();

            dts = bbdd.PortarTaula("Users");
            infotaula = dts.Tables[0];
            dataGridView1.DataSource = dts.Tables[0];

            foreach (Control ctr in this.Controls)
            {
                if (ctr.GetType() == typeof(SW_Textbox))
                {
                    ctr.DataBindings.Clear();
                    ctr.Text = string.Empty;
                    ctr.DataBindings.Add("Text", infotaula, ((SW_Textbox)ctr).NomCamp);
                    ctr.Validated += new System.EventHandler(this.ValidarTextBox);
                }
            }   
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            flag = true;

            foreach (Control ctr in this.Controls)
            {

                if (ctr.GetType() == typeof(SW_Textbox))
                {
                    ctr.DataBindings.Clear();
                    ctr.Text = string.Empty;

                    dr = infotaula.NewRow();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (flag) 
            {
                foreach (Control ctr in this.Controls)
                {
                    if (ctr.GetType() == typeof(SW_Textbox))
                    {
                        dr[((SW_Textbox)ctr).NomCamp] = ctr.Text;
                    }  
                }
                infotaula.Rows.Add(dr);
                flag = false;
            }

            TLR_Dades.Dades bbdd = new TLR_Dades.Dades();
            string query = "Select * from Users";
            bbdd.Actualitzar(dts, query);
        }

        private void ValidarTextBox(object sender, EventArgs e)
        {
            if (!flag)
            {
                ((TextBox)sender).DataBindings[0].BindingManagerBase.EndCurrentEdit();
            }   
        }
    }
}
