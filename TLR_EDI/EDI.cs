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
    public partial class EDI : BaseForm
    {
        public EDI()
        {
            InitializeComponent();
        }

        Dades bbdd = new Dades();

        //Declaracio variables 
        private string idOrder = "", CodeOrder = "", DateOrder = "", idPriority = "", idFactory = "";
        private string idOperationalArea = "", idAgency = "";
        private string idPlanet = "", idReference = "", Quantity = "", DeliveryDate = "";

        EDISecureCoreEntities db;

        private void btnEDI_Click(object sender, EventArgs e)
        {
            db = new EDISecureCoreEntities();

            //Parametres per separar les linies del EDI
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

                        CodeOrder = valors[1];

                        string queryidPriority = "select idPriority from Priority where CodePriority = '" + valors[2] + "'";
                        DataSet dtsIdPriority = bbdd.PortarPerConsulta(queryidPriority);
                        idPriority = dtsIdPriority.Tables[0].Rows[0][0].ToString();
                        break;

                    case "DTM":

                        DateOrder = valors[1];
                        break;

                    case "NADMS":

                        string queryidOperArea = "select idOperationalArea from OperationalAreas " +
                        " where CodeOperationalArea = '" + valors[1] + "'";
                        DataSet dtsidOperArea = bbdd.PortarPerConsulta(queryidOperArea);
                        idOperationalArea = dtsidOperArea.Tables[0].Rows[0][0].ToString();

                        string queryidAgency = "select idAgency from Agencies where CodeAgency = '" + valors[2] + "'";
                        DataSet dtsidAgency = bbdd.PortarPerConsulta(queryidAgency);
                        idAgency = dtsidAgency.Tables[0].Rows[0][0].ToString();
                        break;

                    case "NADMR":

                        string queryidFactory = "Select idFactory from Factories where codeFactory = '" + valors[1] + "'";
                        DataSet dtsidFactory = bbdd.PortarPerConsulta(queryidFactory);
                        idFactory = dtsidFactory.Tables[0].Rows[0][0].ToString();

                        InsertarOrders();
                        InsertarOrdersInfo();
                        break;

                    case "LIN":

                        string queryidPlanet = "select idPlanet from Planets where CodePlanet = '" + valors[1] + "'";
                        DataSet dtsidPlanet = bbdd.PortarPerConsulta(queryidPlanet);
                        idPlanet = dtsidPlanet.Tables[0].Rows[0][0].ToString();

                        string queryidReference = "select idReference from [SecureCore].[dbo].[References] where codeReference = '" + valors[2] + "'";
                        DataSet dtsidReference = bbdd.PortarPerConsulta(queryidReference);
                        idReference = dtsidReference.Tables[0].Rows[0][0].ToString();
                        break;

                    case "QTYLIN":

                        if(int.Parse(valors[1]) == 21)
                        {
                            Quantity = valors[2];
                        }
                        else if(int.Parse(valors[1]) == 61)
                        {
                            Quantity = "-" + valors[2];
                        }
                        break;

                    case "DTMLIN":
                        DeliveryDate = valors[1];

                        InsertarOrdersDetails();
                        break;
                }  
            }                  
        }

        private void InsertarOrders()
        {
            Order orders = new Order
            {
                codeOrder = CodeOrder,
                dateOrder = DateTime.ParseExact(DateOrder, "yyyyMMdd", null),
                IdPriority = short.Parse(idPriority),
                IdFactory = short.Parse(idFactory),
            };

            db.Orders.Add(orders);
            db.SaveChanges();

            //string queryidOrder = "select idOrder from Orders where codeOrder = '" + CodeOrder + "'";
            string queryidOrder = "select top 1 idOrder from Orders order by idOrder desc";
            DataSet dtsidOrdey = bbdd.PortarPerConsulta(queryidOrder);
            idOrder = dtsidOrdey.Tables[0].Rows[0][0].ToString();
        }

        private void InsertarOrdersInfo()
        {
            OrderInfo ordersinfo = new OrderInfo
            {
                idOrder = short.Parse(idOrder),
                idAgency = short.Parse(idAgency),
                idOperationalArea = short.Parse(idOperationalArea),

            };

            db.OrderInfoes.Add(ordersinfo);
            db.SaveChanges();
        }

        private void InsertarOrdersDetails()
        {
            OrdersDetail ordersdetails = new OrdersDetail
            {
                idOrder = short.Parse(idOrder),
                idPlanet = short.Parse(idPlanet),
                idReference = short.Parse(idReference),
                Quantity = short.Parse(Quantity),
                DeliveryDate = DateTime.ParseExact(DeliveryDate, "yyyyMMdd", null)
            };

            db.OrdersDetails.Add(ordersdetails);
            db.SaveChanges();
        }
    }
}
    

