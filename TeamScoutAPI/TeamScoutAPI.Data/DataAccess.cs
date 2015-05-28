using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Configuration;
using System.Data.SqlClient;
using TeamScoutAPI.Data.ObjectModel;
using System.Data;

namespace TeamScoutAPI.Data
{
    public class DataAccess
    {
        public static int GetNumberOfTweets(string arg)
        {
            string cs = "Server=127.0.0.1;Port=5432;Database=projectWork;User Id=teamscout;Password=pass;";
            using (NpgsqlConnection connection = new NpgsqlConnection(cs))
            {
                connection.Open();
                string query = @"SELECT COUNT(*)
                                FROM Tweets
                                WHERE arguments == :arg";
                using (NpgsqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = query;
                    command.CommandType = CommandType.Text;

                    command.Parameters.Add(new NpgsqlParameter("arg", arg));

                    return (int)command.ExecuteScalar();
                }
            }
        }
    }
}
