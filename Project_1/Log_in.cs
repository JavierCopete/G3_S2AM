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
        int contador_s = 0;
        
        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (textBox1.Text == "root" && textBox2.Text == "1234a")
            {
                label5.Hide();
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                label6.Text = ("Bon dia " + textBox1.Text + ", estem validant les seves credencials");
                pictureBox1.Image = Image.FromFile(@"C:\Users\rprod\Pictures\conejo_cola.gif");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                timer1.Enabled = true;
                timer1.Start();      
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
                    label5.Text = ("Usuari i Contrasenya incorrectes, intents restants " + (String)(3 - Error).ToString());
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            contador_s++;
        if (contador_s == 5)
            {
                Menu_usuari obj = new Menu_usuari();
                obj.nom_user = textBox1.Text;
                obj.Show();
                this.Hide();
            }
        }

        private void Log_in_Load(object sender, EventArgs e)
        {

        }
    }
}
