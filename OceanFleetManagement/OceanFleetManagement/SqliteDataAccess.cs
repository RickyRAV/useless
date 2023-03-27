using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using Shipping;

namespace OceanFleetManagement
{
    public class SqliteDataAccess:IDataAccess
    {
        string connectionString = @"Data Source=..\..\..\shipping.db";
        Dictionary<int, ContainerShip> ships = new Dictionary<int, ContainerShip>();
        public Dictionary<int, Shipping.ContainerShip> GetContainerShips() 
        {
            using (SqliteConnection conn = new SqliteConnection(connectionString))
            {
                conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM container_ships";
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ships.Add(reader.GetInt32(0), new ContainerShip(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2)));
                    }
                }
                cmd.CommandText = "SELECT * FROM storage_containers";
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (reader.GetInt32(3) == 1)
                        {
                            StorageContainer storageContainer = new StorageContainer();
                            storageContainer.MaxVolume = reader.GetFloat(2);
                            storageContainer.Id = reader.GetInt32(0);
                            storageContainer.Renter = reader.GetString(1);
                            ships[reader.GetInt32(3)].AddContainer(storageContainer);                            
                        }
                        else if (reader.GetInt32(3) == 2)
                        {
                            StorageContainer storageContainer = new StorageContainer();
                            storageContainer.MaxVolume = reader.GetFloat(2);
                            storageContainer.Id = reader.GetInt32(0);
                            storageContainer.Renter = reader.GetString(1);
                            ships[reader.GetInt32(3)].AddContainer(storageContainer);
                        }
                        else if (reader.GetInt32(3) == 3)
                        {
                            StorageContainer storageContainer = new StorageContainer();
                            storageContainer.MaxVolume = reader.GetFloat(2);
                            storageContainer.Id = reader.GetInt32(0);
                            storageContainer.Renter = reader.GetString(1);
                            ships[reader.GetInt32(3)].AddContainer(storageContainer);
                        }
                    }
                }
            }
            return ships;
        }
    }
}
