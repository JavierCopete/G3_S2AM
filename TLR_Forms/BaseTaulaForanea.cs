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
    public partial class BaseTaulaForanea : BaseForm
    {
        public BaseTaulaForanea()
        {
            InitializeComponent();
        }

        private DataTable infotaula;
        private DataRow dr;
        private DataSet dts;
        private Boolean flag_Textbox;
        private Boolean flag_Combobox;
        private string _NomTaula = "Planets";

        public string NomTaula
        {
            get { return _NomTaula; }
            set { _NomTaula = value; }
        }

        private void BaseTaulaForanea_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;

            Dades bbdd = new Dades();

            dts = bbdd.PortarTaula(NomTaula);
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

                if (ctr.GetType() == typeof(SW_Combobox))
                {
                    ((SW_Combobox)ctr).Llenar_Combo();
                    ctr.DataBindings.Clear();
                    ctr.Text = string.Empty;
                    ctr.DataBindings.Add("SelectedValue", infotaula, ((SW_Combobox)ctr).CampId);
                    ctr.DataBindings.Add("Text", infotaula, ((SW_Combobox)ctr).CampMostrar);
                    ctr.Validated += new System.EventHandler(this.ValidarComboBox);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            flag_Textbox = true;
            flag_Combobox = true;

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
            if (flag_Textbox)
            {
                foreach (Control ctr in this.Controls)
                {
                    if (ctr.GetType() == typeof(SW_Textbox))
                    {
                        dr[((SW_Textbox)ctr).NomCamp] = ctr.Text;
                    }
                }
                infotaula.Rows.Add(dr);
                flag_Textbox = false;
            }

            if (flag_Combobox)
            {
                foreach (Control ctr in this.Controls)
                {
                    if (ctr.GetType() == typeof(SW_Combobox))
                    {
                        dr[((SW_Combobox)ctr).CampId] = ((ComboBox)ctr).SelectedValue;
                    }
                }
                infotaula.Rows.Add(dr);
                flag_Combobox = false;
            }

            TLR_Dades.Dades bbdd = new TLR_Dades.Dades();
            string query = "select * from " + NomTaula;
            bbdd.Actualitzar(dts, query);
        }

        private void ValidarTextBox(object sender, EventArgs e)
        {
            if (!flag_Textbox)
            {
                ((TextBox)sender).DataBindings[0].BindingManagerBase.EndCurrentEdit();
            }
        }

        private void ValidarComboBox(object sender, EventArgs e)
            {
                if (!flag_Combobox)
                {
                    ((ComboBox)sender).DataBindings[0].BindingManagerBase.EndCurrentEdit();
                }
            }
    }
}
