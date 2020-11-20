using System;
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
            Llenar_Combo();
        }

        Dades bbdd = new Dades();

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // SW_Combobox
            // 
            this.SelectedValueChanged += new System.EventHandler(this.SW_Combobox_SelectedValueChanged);
            this.ResumeLayout(false);

        }




        private String _ControlID;
        private String _NomTaula;

        public String ControlID
        {
            get { return _ControlID; }
            set
            {
                _ControlID = value;
            }
        }


        private string _CampMostrar;

        public string CampMostrar
        {
            get { return _CampMostrar; }
            set { _CampMostrar = value; }
        }



        private string _CampId;

        public string CampId
        {
            get { return _CampId; }
            set { _CampId = value; }
        }


        public String NomTaula
        {
            get { return _NomTaula; }
            set
            {
                _NomTaula = value;
            }
        }

        private void Llenar_Combo()
        {
            string tabla = "Planets";
            DataSet dts = bbdd.PortarTaula(tabla);
            DataTable dt = dts.Tables[0];
            this.DataSource = dt;
            this.DisplayMember =this.CampMostrar;
            this.ValueMember = this.CampId;
        }



        private void SW_Combobox_SelectedValueChanged(object sender, EventArgs e)
        {

        }
    }
}
