using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Messi_app
{
    public partial class Menu_MAC : Form
    {
        public Menu_MAC()
        {
            InitializeComponent();

          
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\rprod\Desktop\Logs_guardados\MAC_HOST.log";

            FileInfo fi = new FileInfo(path);


            if (!File.Exists(path))
            {
                //Open file for Read\Write
                FileStream fs = fi.Open(FileMode.OpenOrCreate, FileAccess.Write);
                //Create StreamWriter object to write string to FileSream
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(textBox1.Text + ":" + textBox2.Text);
                sw.Close();
            }
            else
            {
                //Open file for Read\Write
                FileStream fs = fi.Open(FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(textBox1.Text + ":" + textBox2.Text);
                sw.Close();
            }
            Application.Exit();
        }

        private void Menu_MAC_Load(object sender, EventArgs e)
        {
            String hostName = Dns.GetHostName();
            textBox1.Text = hostName;

            string macAddresses = "";
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (nic.OperationalStatus == OperationalStatus.Up && (!nic.Description.Contains("Virtual") && !nic.Description.Contains("Pseudo")))
                {
                    if (nic.GetPhysicalAddress().ToString() != "")
                    {
                        macAddresses = nic.GetPhysicalAddress().ToString();
                    }
                }
            }

            textBox2.Text = macAddresses;
        }
    }
}
