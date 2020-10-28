using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.IsolatedStorage;
using System.Windows.Documents;
using System.Text.RegularExpressions;

namespace Project_1
{

    public partial class SW_Textbox : UserControl
    {
        public SW_Textbox()
        {
            InitializeComponent();
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
        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.MistyRose;
            MessageBox.Show("Aquest control admet " + this.DadaPermesa.ToString());
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.DarkSalmon;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            Regex Texto = new Regex("^[a-zA-Z]+$");
            Regex Numero = new Regex("^[0-9]+$");
            

            switch (this.DadaPermesa)
            {

                case TipusDada.Number:
                    if (Numero.IsMatch(this.Text))
                    {
                        MessageBox.Show("Esto es un numero");
                    } else
                    {
                        e.Cancel = true;
                        textBox1.Clear();                     
                    }
                    break;
                case TipusDada.Text:
                    if (Texto.IsMatch(this.Text))
                    {
                        MessageBox.Show("Esto es un texto");
                    }
                    break;
                    
                //    var Text when new Regex("^[a-zA-Z]+$").IsMatch(textBox1.Text):
                //    MessageBox.Show("Esto es un texto");
                //    break;
                //case var Nume when new Regex("^[0-9]+$").IsMatch(textBox1.Text):
                //    MessageBox.Show("Esto es un Numero");
                //    break;
            }
        }
    }
}
