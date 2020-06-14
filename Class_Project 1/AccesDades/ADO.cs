using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesDades
{
    public class ADO
    {
        private string Conexion = "Server=estrelladam.database.windows.net; Database=EstrellaDam; User Id=estrelladam; Password=123456aA";
        public SqlConnection sqlConexion;
        public SqlDataAdapter adapter;

        public void Connectar()
        {
            sqlConexion = new SqlConnection(Conexion);
            sqlConexion.Open();
        }

        public DataSet PortarTaula(string taula)
        {
            string query = "SELECT * " +
                           "FROM " + taula;
            adapter = new SqlDataAdapter(query, sqlConexion);
            DataSet data = new DataSet();
            adapter.Fill(data);
            return data;
        }

        public DataSet PortaDades(string query)
        {
            Connectar();

            adapter = new SqlDataAdapter(query, sqlConexion);
            DataSet data = new DataSet();
            adapter.Fill(data);

            return data;
        }

        public DataSet PortarPerConsulta(string query)
        {
            DataSet data = new DataSet();
            adapter = new SqlDataAdapter(query, sqlConexion);
            SqlCommandBuilder cmdBuilder;
            cmdBuilder = new SqlCommandBuilder(adapter);

            adapter.Fill(data);
            return data;
        }

        public void Actualitzar(string query, DataSet ds)
        {
            adapter = new SqlDataAdapter(query, sqlConexion);
            SqlCommandBuilder cmdBuilder;
            cmdBuilder = new SqlCommandBuilder(adapter);

            if (ds.HasChanges())
            {
                adapter.Update(ds.Tables[0]);
            }
            sqlConexion.Close();
        }

        public int Executa(string consulta)
        {
            int filesAfectades;

            SqlCommand query = new SqlCommand(consulta, sqlConexion);
            filesAfectades = query.ExecuteNonQuery();

            return filesAfectades;
        }
    }
}
