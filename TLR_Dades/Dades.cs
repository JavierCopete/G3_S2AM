using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TLR_Dades
{
    public class Dades
    {
        private SqlConnection conn;
        private string cnx;

        private void Connectar()
        {
            cnx = "Data Source=DESKTOP-NL97QBH;Initial Catalog=SecureCore;Integrated Security=True"; //Javier
            //cnx = "Data Source=LAPTOP-3CMMKCMH;Initial Catalog=SecureCore;Integrated Security=True"; //Rubén
            //cnx = "Data Source=MSI-EDU\\SQLExpress;Initial Catalog=SecureCore;Integrated Security=True"; //Edu
            conn = new SqlConnection(cnx);
        }

        public DataSet PortarTaula(string nom_taula)
        {
            Connectar();

            SqlDataAdapter adapter;
            string query;
            query = "select * from " + nom_taula;
            adapter = new SqlDataAdapter(query, conn);
            
            conn.Open();

            DataSet dts = new DataSet();
            adapter.Fill(dts, nom_taula);
            conn.Close();

            return dts;
        }

        public DataSet PortarPerConsulta(string consulta)
        {
            Connectar();

            SqlDataAdapter adapter;
            adapter = new SqlDataAdapter(consulta, conn);

            conn.Open();

            DataSet dts = new DataSet();
            adapter.Fill(dts);
            conn.Close();

            return dts;
        }

        public DataSet PortarPerConsulta(string consulta, string taula)
        {
            Connectar();

            SqlDataAdapter adapter;
            adapter = new SqlDataAdapter(consulta, conn);

            conn.Open();

            DataSet dts = new DataSet();
            adapter.Fill(dts, taula);
            conn.Close();

            return dts;
        }

        public void Actualitzar(DataSet dts, string query)
        {

            Connectar();
            conn.Open();

            SqlDataAdapter adapter;
            adapter = new SqlDataAdapter(query, conn);
            SqlCommandBuilder cmdBuilder;
            cmdBuilder = new SqlCommandBuilder(adapter);

            if (dts.HasChanges())
            {
                int result = adapter.Update(dts.Tables[0]);
            }

            conn.Close();
        }

        public void Executa(string consulta)
        {
            Connectar();
            conn.Open();
            SqlCommand cmd;
            cmd = new SqlCommand(consulta, conn);
            int registresAfectats = cmd.ExecuteNonQuery();
            cmd.Dispose();
        }
    }
}
