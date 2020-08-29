/*using FlywayAirlines.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace FlywayAirlines.Repositories
{
    public class AircraftRepository : IAircraftRepository
    {
        MySqlConnection connection;
        public AircraftRepository(MySqlConnection connection)
        {
            this.connection = connection;
        }
        public List<Aircraft> getAll()
        {
            List<Aircraft> aircrafts = new List<Aircraft>();
            try
            {

                connection.Open();
                string sql = "SELECT id,registrationNumber,name, type, manufacturer, cruiseSpeed from aircrafts";
                string aircraftCapacityQuery = $"select aircraftId, sum(capacity) from Cabins c group by c.AircraftId";

                MySqlCommand command = new MySqlCommand(sql, connection);
                MySqlDataReader reader = command.ExecuteReader();

                var aircraftCapacityQueryCommand = new MySqlCommand(aircraftCapacityQuery, connection);
                var aircraftCapacityReader = aircraftCapacityQueryCommand.ExecuteReader();

                var aircraftCapacityMap = new Dictionary<int, int>();

                while (aircraftCapacityReader.Read())
                {
                    int aircraftId = reader.GetInt32(0);
                    int capacity = reader.GetInt32(1);
                    aircraftCapacityMap[aircraftId] = capacity;
                }

                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string name = reader.GetString(2);
                    string type = reader.GetString(3);
                    string registrationNumber = reader.GetString(1);
                    string manufacturer = reader.GetString(7);
                    int cruiseSpeed = reader.GetInt32(5);

                    aircraftCapacityMap.TryGetValue(id, out var capacity);

                    Aircraft aircraft = new Aircraft(id, name, type, registrationNumber, manufacturer, cruiseSpeed, capacity);
                    aircrafts.Add(aircraft);
                    Console.WriteLine(reader[0] + " -- " + reader[1]);
                }
                reader.Close();

                connection.Close();
                Console.WriteLine("Done.");

            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return aircrafts;
        }

        public bool create(string name, string type, string registrationNumber, string manufacturer, int cruiseSpeed, ICollection<Cabin> cabins)
        {
            try
            {
                connection.Open();
                string sql = "insert into aircrafts (registrationNumber,name,type, manufacturer, cruiseSpeed) values ('" + registrationNumber + "','" + name + "','" + type + "', '" + manufacturer + "', '" + cruiseSpeed + "')";

                MySqlCommand command = new MySqlCommand(sql, connection);
                int count = command.ExecuteNonQuery();

                if (count > 0)
                {
                    string aircraftCapacityQuery = $"insert into cabins (aircraftId, capacity) values ";

                    foreach (var cabin in cabins)
                    {
                        aircraftCapacityQuery += $"({command.LastInsertedId}, {cabin.capacity})";
                    }

                    var aircraftCapacityQueryCommand = new MySqlCommand(aircraftCapacityQuery, connection);
                    var aircraftCapacityReader = aircraftCapacityQueryCommand.ExecuteReader();
                    connection.Close();
                    return true;
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            connection.Close();
            return false;
        }


        public bool update(int id, string name, string type, string registrationNumber, string manufacturer, int cruiseSpeed)
        {
            try
            {
                connection.Open();
                var sql = "update aircrafts set name ='" + name + "',type='" + type + "',registrationNumber='" + registrationNumber + "',  manufacturer='" + manufacturer + "', cruiseSpeed='" + cruiseSpeed + "' where id='" + id + "'";
                MySqlCommand command = new MySqlCommand(sql, connection);
                int count = command.ExecuteNonQuery();
                if (count > 0)
                {
                    connection.Close();
                    return true;
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            connection.Close();
            return false;
        }


        public bool remove(int id)
        {

            try
            {
                connection.Open();
                var sql = "delete from aircrafts where id='" + id + "'";
                MySqlCommand command = new MySqlCommand(sql, connection);

                int count = command.ExecuteNonQuery();
                if (count > 0)
                {
                    connection.Close();
                    return true;
                }

            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            connection.Close();
            return false;
        }


        public Aircraft find(string registrationNumber)
        {
            Aircraft aircraft = null;
            try
            {
                connection.Open();
                var sql = "select id, registrationNumber, name, type, manufacturer, cruiseSpeed from aircrafts where registrationNumber = '" + registrationNumber + "'";
                MySqlCommand command = new MySqlCommand(sql, connection);

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    int id = reader.GetInt32(0);
                    string name = reader.GetString(2);
                    string type = reader.GetString(3);
                    //string registrationNumber = reader.GetString(1);
                    string manufacturer = reader.GetString(4);
                    int cruiseSpeed = reader.GetInt32(5);
                    aircraft = new Aircraft(id, name, type, registrationNumber, manufacturer, cruiseSpeed);

                }
                Console.WriteLine(reader[0] + " -- " + reader[1]);


            }

            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            connection.Close();
            return aircraft;

        }

        public void displayAll()
        {
            List<Aircraft> aircrafts = getAll();
            foreach (Aircraft aircraft in aircrafts)
            {
                Console.WriteLine($"{aircraft.getId()}, " +
                    $"{aircraft.getRegistrationNumber()}, " +
                    $"{aircraft.getName()}, " +
                    $"{aircraft.getType()}, " +
                    $"{aircraft.getManufacturer()}, " +
                    $"{aircraft.getCruiseSpeed()}");
            }
        }

        public Aircraft findById(int id)
        {
            Aircraft aircraft = null;
            try
            {
                connection.Open();
                var sql = "select id, registrationNumber, name, type, manufacturer, cruiseSpeed from aircrafts where id = '" + id + "'";
                MySqlCommand command = new MySqlCommand(sql, connection);

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    // int id = reader.GetInt32(0);
                    string name = reader.GetString(2);
                    string type = reader.GetString(3);
                    string registrationNumber = reader.GetString(1);
                    string manufacturer = reader.GetString(4);
                    int cruiseSpeed = reader.GetInt32(5);
                    aircraft = new Aircraft(id, name, type, registrationNumber, manufacturer, cruiseSpeed);

                }
                Console.WriteLine(reader[0] + " -- " + reader[1]);


            }

            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            connection.Close();
            return aircraft;
        }
    }
}

 
 
 using FlywayAirlines.Models;
using System.Collections.Generic;
using System.Linq;

namespace FlywayAirlines
{
    public class Aircraft
    {
        //instance variables or parameters
        private int id;
        private string registrationNumber;
        private string type;
        private string name;
        private string manufacturer;
        private int cruiseSpeed;
        private int capacity;
        private ICollection<Cabin> cabins;

        public Aircraft(int id, string name, string type, string registrationNumber, string manufacturer, int cruiseSpeed, int capacity) 
            : this(id, name, type, registrationNumber, manufacturer, cruiseSpeed)
        {
            this.capacity = capacity;
        }

        public Aircraft(int id, string name, string type, string registrationNumber, string manufacturer, int cruiseSpeed, ICollection<Cabin> cabins)
            : this(id, name, type, registrationNumber, manufacturer, cruiseSpeed)
        {
            this.cabins = cabins;
            capacity = cabins.Sum(c => c.capacity);
        }

        public Aircraft(int id, string name, string type, string registrationNumber, string manufacturer, int cruiseSpeed) //constructor is a method used to instantiate the object , has the same name as the class
        {
            //(this) is a special keyword and a reference to the current instance of the class
            this.id = id;
            this.name = name;
            this.type = type;
            this.registrationNumber = registrationNumber;
            this.manufacturer = manufacturer;
            this.cruiseSpeed = cruiseSpeed;
        }




        public void setId(int id)
        {
            this.id = id;
        }
        public int getId()
        {
            return id;
        }

        public void setCapacity(int capacity)
        {
            this.capacity = capacity;
        }
        public int getCapacity()
        {
            return capacity;
        }

        public void setName(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return name;
        }

        public void setManufacturer(string manufacturer)
        {
            this.manufacturer = manufacturer;
        }
        public string getManufacturer()
        {
            return manufacturer;
        }

        public void setCruiseSpeed(int cruiseSpeed)
        {
            this.cruiseSpeed = cruiseSpeed;
        }


        public int getCruiseSpeed()
        {
            return cruiseSpeed;
        }


        public void setType(string type)
        {
            this.type = type;
        }


        public string getType()
        {
            return type;
        }

        public void setRegistrationNumber(string registrationNumber)
        {
            this.registrationNumber = registrationNumber;
        }


        public string getRegistrationNumber()
        {
            return registrationNumber;
        }


        public override string ToString()
        {
            return $"{id}\t{registrationNumber}\t{name}\t{type}\t{manufacturer}\t{cruiseSpeed}";
        }
    }
}


 
 
 */
