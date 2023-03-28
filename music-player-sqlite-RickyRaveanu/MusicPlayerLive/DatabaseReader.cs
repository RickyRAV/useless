using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace MusicPlayerLive
{
    public class DatabaseReader
    {
        string connectionString = @"Data Source=..\..\..\music_library.db";
        public Dictionary<int, Album> ReadData()
        {
            Dictionary<int, Album> albums = new Dictionary<int, Album>();
            using (SqliteConnection con = new SqliteConnection(connectionString))
            {
                con.Open();

                // TODO: 1. commit "Alben aus der DB lesen und im Dictionary speichern"
                var cmd = con.CreateCommand();
                cmd.CommandText = "SELECT * FROM albums";
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        albums.Add(reader.GetInt32(0), new Album(reader.GetString(1), reader.GetString(2), reader.GetInt32(3)));
                    }
                }
            }
            return albums;
        }
    }
}
