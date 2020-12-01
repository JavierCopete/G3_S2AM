using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.IO.IsolatedStorage;
using System.Text.RegularExpressions;
using System.ComponentModel;
using System.Data;
using System.Reflection;

namespace Tlr_controls
{
    public partial class SW_LLenca : Button
    {
        public SW_LLenca()
        {
            InitializeComponent();
        }

        private String _DLL;
        private String _Form;

        public String DLL
        {
            get { return _DLL; }
            set
            {
                _DLL = value;
            }
        }
        public String Form
        {
            get { return _Form; }
            set
            {
                _Form = value;
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // SW_LLenca
            // 
            this.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Click += new System.EventHandler(this.SW_LLenca_Click);
            this.ResumeLayout(false);

        }

        private void SW_LLenca_Click(object sender, EventArgs e)
        {
            int posicio = Form.IndexOf(".");
            string nomForm = Form.Substring(posicio + 1);
            
            //foreach (Form ff in Application.OpenForms)
            //{
            //    if (ff.Name == (nomForm)
            //    {
            //        ff.BringToFront();
            //    }
            //}
            //else
            //{
                    Assembly ensamblat = Assembly.LoadFrom(DLL);

                //Declarem les variables
                Object dllBD;
                Type tipus;

                //recuperem el tipus de la classe que volem instanciar
                tipus = ensamblat.GetType(Form);

                //instanciem l’objecte   
                dllBD = Activator.CreateInstance(tipus);

                //el mostrem assumint que es tracta d’un form 
                // i per això fem un cast amb (Form)
                Form frm = this.FindForm();

                foreach (Control ctr in frm.Controls)
                {
                    if (ctr.Name == "pnlPrincipal")
                    {
                        if (ctr.Controls.Count > 0)
                            ctr.Controls.RemoveAt(0);
                        ctr.Show();




                        ((Form)dllBD).TopLevel = false;
                        ((Form)dllBD).Dock = DockStyle.Fill;
                        ctr.Controls.Add(((Form)dllBD));

                        ((Form)dllBD).Show();
                    }
                }
            //}
        }
    }
}
