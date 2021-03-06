﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using TLR_Dades;
using System.Data;

namespace Tlr_controls
{
    public class SW_Combobox :  ComboBox
    {
        public SW_Combobox()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // SW_Combobox
            // 
            this.SelectedValueChanged += new System.EventHandler(this.SW_Combobox_SelectedValueChanged);
            this.ResumeLayout(false);

        }

        Dades bbdd = new Dades();
        private string _ControlID;
        private string _NomTaula;
        private string _CampMostrar;
        private string _CampId;


        public string ControlID
        {
            get { return _ControlID; }
            set
            {
                _ControlID = value;
            }
        }  


        public string CampMostrar
        {
            get { return _CampMostrar; }
            set
            {
                _CampMostrar = value;
            }
        }


        public string CampId
        {
            get { return _CampId; }
            set
            {
                _CampId = value;
            }
        }


        public String NomTaula
        {
            get { return _NomTaula; }
            set
            {
                _NomTaula = value;
            }
        }

        public void Llenar_Combo()
        {
            string tabla = this.NomTaula;
            DataSet dts = bbdd.PortarTaula(tabla);
            DataTable dt = dts.Tables[0];
            this.DataSource = dt;
            this.DisplayMember = this.CampMostrar;
            this.ValueMember = this.CampId;
        }


        private void SW_Combobox_SelectedValueChanged(object sender, EventArgs e)
        {
            Form frm = this.FindForm();

            foreach (Control ctr in frm.Controls)
            {
                if (_ControlID == ctr.Name)
                {
                    ctr.Text = SelectedValue.ToString();
                }
            }
        }
    }
}
