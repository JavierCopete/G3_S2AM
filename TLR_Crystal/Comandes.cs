using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TLR_Forms;
using TLR_Dades;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Threading;

namespace TLR_Crystal
{
    public partial class Comandes : BaseForm
    {
        public Comandes()
        {
            InitializeComponent();
        }

        private void Comandes_Load(object sender, EventArgs e)
        {
            Dades bbdd = new Dades();
            String NomTaula = "Orders";
            String CampTaula = "idOrder";

            DataSet dts = bbdd.PortarTaula(NomTaula);
            DataTable infotaula = dts.Tables[0];
            dataGridView1.DataSource = dts.Tables[0];

            label1.DataBindings.Add("Text", infotaula, CampTaula);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(@"C:\Users\Edu\Desktop\Copias GitHub\G3_S2AM\TLR_Crystal\TLR_Comandes.rpt");

            ParameterFieldDefinitions crParameterFieldDefinitions;
            ParameterFieldDefinition crParameterFieldDefinition;
            ParameterValues crParameterValues = new ParameterValues();
            ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

            crParameterDiscreteValue.Value = Convert.ToInt32(label1.Text);
            crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["idComanda"];
            crParameterValues = crParameterFieldDefinition.CurrentValues;

            crParameterValues.Clear();
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();
        }
    }
}
