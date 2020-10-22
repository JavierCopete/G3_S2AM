using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Messi_app
{
    public partial class Log : Form
    {
        public Log()
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
                obj.Show();
            }
            else if(textBox1.Text == "Javahut" && textBox2.Text != "1234a")
            {
                
                textBox2.Clear();

                MessageBox.Show("Usuari Reconegut, Contrasenya incorrecta");
                
            }
            else
            {
                 Error++;

                if(Error == 3)
                {
                    timer1.Enabled = true;
                    string Hora_Actual, Data_Actual;
                    Hora_Actual = DateTime.Now.ToString("hhmmss");
                    Data_Actual = DateTime.Now.ToString("yyyyMMdd");
                    string path = @"C:\Users\rprod\Desktop\Logs_guardados\log_errors.log";

                    FileInfo fi = new FileInfo(path);

                    
                    if (!File.Exists(path))
                    {
                        //Open file for Read\Write
                        FileStream fs = fi.Open(FileMode.OpenOrCreate, FileAccess.Write);
                        //Create StreamWriter object to write string to FileSream
                        StreamWriter sw = new StreamWriter(fs);
                        sw.WriteLine(Data_Actual + ":" + Hora_Actual + ":" + textBox1.Text);
                        sw.Close();
                    }
                    else
                    {
                        //Open file for Read\Write
                        FileStream fs = fi.Open(FileMode.Append , FileAccess.Write);
                        StreamWriter sw = new StreamWriter(fs);
                        sw.WriteLine(Data_Actual + ":" + Hora_Actual + ":" + textBox1.Text);
                        sw.Close();
                    }
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("Usuari i Contrasenya incorrectes, intents restants " + (String)(3 - Error).ToString());
                }
                textBox1.Clear();
                textBox2.Clear();
            }
        }
    }
}
