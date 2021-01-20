using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TLR_Forms;

namespace TLR_FTP
{
    public partial class FTP : BaseForm
    {
        public FTP()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {          
            // Get the object used to communicate with the server.
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://192.168.10.1/pedido.edi");
            request.Method = WebRequestMethods.Ftp.UploadFile;

            // This example assumes the FTP site uses anonymous logon.
            request.Credentials = new NetworkCredential("g3", "12345aA");

            // Copy the contents of the file to the request stream.
            byte[] fileContents;
            using (StreamReader sourceStream = new StreamReader(@"C:\Users\Edu\Desktop\Copias GitHub\G3_S2AM\DLL\pedido.edi"))
            {
                fileContents = Encoding.UTF8.GetBytes(sourceStream.ReadToEnd());
            }

            request.ContentLength = fileContents.Length;

            using (Stream requestStream = request.GetRequestStream())
            {
                requestStream.Write(fileContents, 0, fileContents.Length);
            }

            using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
            {
                Console.WriteLine($"Upload File Complete, status {response.StatusDescription}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProcessStartInfo EXE = new ProcessStartInfo("TLR_Descarga.exe");
            Process.Start(EXE);
            EXE.Arguments = "header.h";
        }
    }
}
