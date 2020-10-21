using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1
{
    public partial class Log_in : Form
    {
        public Log_in()
        {
            InitializeComponent();
        }
        int Error = 0;

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (textBox1.Text == "Javahut" && textBox2.Text == "1234a")
            {
                this.Hide();
                Menu_usuari obj = new Menu_usuari();
                obj.nom_user = textBox1.Text;
                obj.Show();
            }
            else if (textBox1.Text == "Javahut" && textBox2.Text != "1234a")
            {

                textBox2.Clear();

                MessageBox.Show("Usuari Reconegut, Contrasenya incorrecta");

            }
            else
            {
                Error++;
                textBox1.Clear();
                textBox2.Clear();

                if (Error == 3)
                {
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("Usuari i Contrasenya incorrectes, intents restants " + (String)(3 - Error).ToString());
                }
            }
        }
    }
}
