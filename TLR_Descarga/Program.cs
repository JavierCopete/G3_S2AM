using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TLR_Descarga
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
           
            do
            {
                Console.WriteLine("\n------- LISTADO DE COMANDOS ------- \n");
                Console.WriteLine("--> Inserte dw para comenzar la descarga ");
                Console.WriteLine("--> Inserte extra para descubrir el easter egg");
                Console.WriteLine("--> Inserte exit para acabar el programa ");
                Console.WriteLine("Ningún comando mas sera valido\n");
                input = Console.ReadLine();
                {

                    if (input == "dw")
                    {
                        FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://192.168.10.1/pedido.edi");
                        request.Method = WebRequestMethods.Ftp.DownloadFile;

                        // This example assumes the FTP site uses anonymous logon.
                        request.Credentials = new NetworkCredential("g3", "12345aA");

                        FtpWebResponse response = (FtpWebResponse)request.GetResponse();

                        Stream responseStream = response.GetResponseStream();
                        StreamReader reader = new StreamReader(responseStream);
                        Console.WriteLine(reader.ReadToEnd());

                        Console.WriteLine($"Download Complete, status {response.StatusDescription}");
                        reader.Close();
                        response.Close();
                    }
                    else if(input == "extra")
                    {
                        Console.WriteLine("QUE LA ZANAHORIA TE ACOMPAÑE!!!\n ");
                        Console.WriteLine("--------------------------------------\n ");
                        Console.WriteLine("''''' ");
                        Console.WriteLine("ºYºP" +
                            "\n O ");
                    }
                    else
                    {
                        Console.WriteLine("Invalid Command");
                    }
                }
            } while (input != "exit");

            // Get the object used to communicate with the server.

        }
    }
}