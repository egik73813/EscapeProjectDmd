using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Model
{
    public class DbHelper
    {
        public static List<Geozone> getGeozones()
        {
            using (var context = new EscapeModel())
            {
                var data = context.Geozone;
                if (data != null)
                {
                    var list = data.ToList();
                    return list;
                }
                return new List<Geozone>();
            }
        }
  const string ConnParam = "Server=localhost;Port=5432;User Id=postgres;Password=0000;Database=Project;";
            
        public static List<string> Recursive()
        {
            var query =
                "WITH RECURSIVE r AS (SELECT \"City_to\" FROM \"Flights\" WHERE \"City_from\" = 55 UNION SELECT \"Flights\".\"City_to\" FROM \"Flights\" JOIN r ON \"Flights\".\"City_from\" = r.\"City_to\") SELECT C.\"Name\" FROM r JOIN \"Cities\" C ON C.\"City_id\" = r.\"City_to\"";

         
            var conn = new NpgsqlConnection(ConnParam);
            var comm = new NpgsqlCommand(query, conn);
            conn.Open();
            var reader = comm.ExecuteReader();
            var retList = new List<string>();
            while (reader.Read())
            {
                var result1 = reader.GetString(0);
                retList.Add(result1);
            }
            conn.Close();
            return retList;

        }




        public static List<string[]> getRoute()
        {
            using (var connection = new NpgsqlConnection())
            {
                string conn_param = "Server=localhost;Port=5432;User Id=postgres;Password=0000;Database=Project;";
                string sql = "SELECT F.\"Flight_id\", C.\"Name\", F.\"Duration\" FROM \"Cities\" C JOIN \"Flights\" F ON C.\"City_id\" = F.\"City_to\" AND F.\"City_from\" = (SELECT \"City_id\" FROM \"Cities\" WHERE \"Name\" = 'Kaluga')";
                NpgsqlConnection conn = new NpgsqlConnection(conn_param);
                NpgsqlCommand comm = new NpgsqlCommand(sql, conn);
                conn.Open(); //Открываем соединение.
                NpgsqlDataReader reader;
                reader = comm.ExecuteReader();
                List<string[]> retList = new List<string[]>();
                while (reader.Read())
                {
                    try
                    {
                        var result1 = reader.GetString(0);
                        var result2 = reader.GetString(1);
                        var result3 = reader.GetString(2);
                        retList.Add(new string[] { result1, result2,result3 });
                    }
                    catch
                    {
                        // ignored
                    }
                }
                conn.Close(); return retList;
            }

        }

        public static List<string[]> getRoute(long duration)
        {
            using (var connection = new NpgsqlConnection())
            {
                string conn_param = "Server=localhost;Port=5432;User Id=postgres;Password=0000;Database=Project;";
                string sql = "SELECT S1.\"Name\", S2.\"Name\" FROM \"Flights\" F JOIN \"Cities\" S1 ON F.\"City_from\" = S1.\"City_id\" JOIN \"Cities\" S2 ON F.\"City_to\" = S2.\"City_id\" WHERE F.\"Duration\" < 10";
                NpgsqlConnection conn = new NpgsqlConnection(conn_param);
                NpgsqlCommand comm = new NpgsqlCommand(sql, conn);
                conn.Open(); //Открываем соединение.
                NpgsqlDataReader reader;
                reader = comm.ExecuteReader();
                List<string[]> retList = new List<string[]>();
                while (reader.Read())
                {
                    try
                    {
                        var result1 = reader.GetString(0);
                        var result2 = reader.GetString(1);
                        retList.Add(new string[] { result1, result2 });
                    }
                    catch
                    {
                        // ignored
                    }
                }
                conn.Close(); return retList;
            }

        }
    }
}
