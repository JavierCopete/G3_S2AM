using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Messi_app
{
    public partial class Admin : Form
    {
        //private IEnumerable<object> numrandoms;
        
        public Admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            tableLayoutPanel1.Controls.Clear();
            Random rdn = new Random();
            int number = rdn.Next(0, 9);
            char letter = (char)rdn.Next('A', 'D');
            label1.Text = number.ToString() + letter.ToString();

            Llamada_Array();
            
            for (int i = 0; i <= 11; i++)
            {
                Button button2 = new Button();
                if (i != 9 && i != 11)
                {
                    tableLayoutPanel1.Controls.Add(button2);
                    int valor = numrandoms.Dequeue();
                    button2.Text = valor.ToString();
                    button2.Click += new System.EventHandler(Click_Lay_butt);   
                }
                else if (i == 9)
                {
                    tableLayoutPanel1.Controls.Add(button2);
                    button2.Text = "C";
                    button2.Click += new System.EventHandler(Click_C);
                }
                else if (i == 11)
                {
                    tableLayoutPanel1.Controls.Add(button2);
                    button2.Text = "✶";
                    button2.Click += new System.EventHandler(Click_ast);   
                } 
                }   
        }
        private void Click_C(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
        private void Click_ast(object sender, EventArgs e)
        {
            if (textBox1.Text == "1234")
            {
                this.Hide();
                Menu_MAC obj = new Menu_MAC();
                obj.Show();
            }
            else
            {
                MessageBox.Show("Contrasenya Incorrecta");
                textBox1.Clear();
            }
        }
        private void Click_Lay_butt(object sender, EventArgs e)
        {
            if (textBox1.Text.Length<4) {
                textBox1.Text = textBox1.Text + ((sender as Button).Text);
            }
        }

        Queue<int> numrandoms = new Queue<int>();
        private void Llamada_Array()
        {
            ArrayList arlistnumber = new ArrayList();

            for (int i = 0; i <= 9; i++)
            {
                arlistnumber.Add(i);
            }

            while (arlistnumber.Count > 0)
            {
                Random rnd = new Random();
                int num = rnd.Next(0, arlistnumber.Count - 1);
                int valor = (int)arlistnumber[num];
                numrandoms.Enqueue(valor);
                arlistnumber.RemoveAt(num);
            }

            foreach (var id in numrandoms)
                Console.WriteLine(id);
        }
        private void Admin_Load(object sender, EventArgs e)
        {
            Llamada_Array();
        }
    }
}
