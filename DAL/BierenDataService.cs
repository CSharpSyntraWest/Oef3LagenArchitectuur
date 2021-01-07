using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class BierenDataService : IBierenDataService
    {
        private string connString = "Data Source=.;Initial Catalog=BierenDb;Integrated Security=True";
        public BierenDataService()
        {
            
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = connString;
            sqlConnection.Open();
            ConnectionState state = sqlConnection.State;
            sqlConnection.Close();
        }
        public IList<Bieren> GeefAlleBierenVoorSoort()
        {
            using (SqlConnection sqlConn = new SqlConnection(connString))
            {
                sqlConn.Open();
                ConnectionState state = sqlConn.State;
                //Afsluiten van connectie gebeurt automatisch bij using(...){...}
            }

            return null;//ik wil dit uit de sql bierenDb halen

            //Verschillende mogelijkheden:
            //1. Zelf SQL connectie openen , gegevens ophalen
            // in de lijst van bieren plaatsen en teruggeven
            //= Zelf Data Access layer schrijven (bv ADO.NET)
            //2.Gebruik maken van ORM (Object Relational Mapper)
            //bv EntityFrameWork (Core) of Dapper
        }
    }
}
