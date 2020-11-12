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

namespace Tlr_controls
{
    public class SW_Textbox : TextBox
    {
        public SW_Textbox()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // SW_Textbox
            // 
            this.Enter += new System.EventHandler(this.SW_Textbox_Enter);
            this.Leave += new System.EventHandler(this.SW_Textbox_Leave);
            this.Validating += new System.ComponentModel.CancelEventHandler(this.SW_Textbox_Validating);
            this.ResumeLayout(false);
        }
        public enum TipusDada
        {
            Number,
            Text,
            Data,
            Codi
        }

        private TipusDada _DadaPermesa;
        public TipusDada DadaPermesa
        {
            get { return _DadaPermesa; }
            set
            {
                _DadaPermesa = value;
            }
        }
        private String _NomCamp;
        public String NomCamp
        {
            get { return _NomCamp; }
            set
            {
                _NomCamp = value;
            }
        }

        private bool _Obligatori;

        public bool Obligatori
        {
            get { return _Obligatori; }
            set
            {
                _Obligatori = value;
            }
        }

        private bool _Foranea;

        public bool Foranea
        {
            get { return _Foranea; }
            set
            {
                _Foranea = value;
            }
        }

        private void SW_Textbox_Validating(object sender, CancelEventArgs e)
        {
            Regex Texto = new Regex("^[a-zA-Z]+$");
            Regex Numero = new Regex("^[0-9]+$");
            Regex Fecha = new Regex("^([0-2][0-9]|3[0-1])(\\/|-)(0[1-9]|1[0-2])\\2(\\d{4})+$");
            Regex Codigo = new Regex("^[A-Z][A-Z][A-Z][A-Z]-[0-9][0-9][0-9]/[13579][AEIOU]+$");

            switch (DadaPermesa)
            {

                case TipusDada.Text:
                    if (!Texto.IsMatch(this.Text) && Obligatori == true)
                    {
                        e.Cancel = true;
                    }
                    else if (!Texto.IsMatch(this.Text))
                    {
                        e.Cancel = false;
                    }
                    else
                    {
                        e.Cancel = false;
                    }
                    break;
                case TipusDada.Number:
                    if (!Numero.IsMatch(this.Text) && Obligatori == true)
                    {
                        e.Cancel = true;
                    }
                    else if (!Numero.IsMatch(this.Text))
                    {
                        e.Cancel = false;
                    }
                    else
                    {
                        e.Cancel = false;
                    }
                    break;
                case TipusDada.Data:
                    if (!Fecha.IsMatch(this.Text) && Obligatori == true)
                    {
                        e.Cancel = true;
                    }
                    else if (!Fecha.IsMatch(this.Text))
                    {
                        e.Cancel = false;
                    }
                    else
                    {
                        e.Cancel = false;
                    }
                    break;
                case TipusDada.Codi:
                    if (!Codigo.IsMatch(this.Text) && Obligatori == true)
                    {
                        e.Cancel = true;
                    }
                    else if (!Codigo.IsMatch(this.Text))
                    {
                        e.Cancel = false;
                    }
                    else
                    {
                        e.Cancel = false;
                    }
                    break;
            }

            if (Foranea == true)
            {
                //FALTA HACER
            }
        }

        private void SW_Textbox_Enter(object sender, EventArgs e)
        {
            this.BackColor = Color.MistyRose;
        }

        private void SW_Textbox_Leave(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkSalmon;
        }
    }
}
