using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TLR_Forms;
using TLR_Dades;
using System.IO;

namespace TLR_EDI
{
    public partial class EDI : Form
    {
        public EDI()
        {
            InitializeComponent();
        }

        private void btnEDI_Click(object sender, EventArgs e)
        {
            Dades bbdd = new Dades();

            char[] fi_linea = { '\r', '\n' };

            string[] linies = File.ReadAllText(Application.StartupPath + @"\pedido.edi").Split(fi_linea, System.StringSplitOptions.RemoveEmptyEntries);
            int num_linies = linies.Length;

            for (int i = 0; i < num_linies; i++)
            {
                char[] separador = new char[] { '|' };
                string[] valors = linies[i].Split(separador, StringSplitOptions.RemoveEmptyEntries);

                   switch (valors[0])
                   {
                        case "ORD":

                            DataSet dtsNewContact = bbdd.PortarTaula("NewContact");
                            DataRow drNewContact = dtsNewContact.Tables[0].NewRow();

                //            //Insercio dels valors a la row
                //            drNewContact["Name"] = valors[1];
                //            drNewContact["BirthDate"] = valors[2];

                //            //Insercio a la BBDD
                //            dtsNewContact.Tables[0].Rows.Add(drNewContact);
                //            string queryNewContact = "select * from NewContact";
                //            bbdd.Actualitzar(dtsNewContact, queryNewContact);


                //            //Trobar Id
                //            string query = "select idContact from NewContact where Name = '" + valors[1] + "' and BirthDate = '" + valors[2] + "'";
                //            DataSet dtsidcontact = bbdd.PortarPerConsulta(query);

                //            idContact = dtsidcontact.Tables[0].Rows[0]["idContact"].ToString();
                            break;

                //        case "SYS":


                //    }
                }
            }
        }
    }
    }

