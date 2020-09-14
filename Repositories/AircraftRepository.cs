using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

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
                    string sql = "SELECT id,registrationNumber,name, type,capacity, manufacturer, cruiseSpeed from aircrafts";

                    MySqlCommand command = new MySqlCommand(sql, connection);
                    MySqlDataReader reader = command.ExecuteReader();


                    while (reader.Read())
                    {
                        {

                            int id = reader.GetInt32(0);
                            string name = reader.GetString(2);
                            string type = reader.GetString(3);
                            string registrationNumber = reader.GetString(1);
                            int capacity = reader.GetInt32(4);
                            string manufacturer = reader.GetString(5);
                            int cruiseSpeed = reader.GetInt32(6);

                        Aircraft aircraft = new Aircraft(id, name, type, registrationNumber, capacity, manufacturer, cruiseSpeed);
                            aircrafts.Add(aircraft);

                        }
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

            public bool create(string name, string type, string registrationNumber, int capacity, string manufacturer, int cruiseSpeed)
            {
                try
                {
                    connection.Open();
                    string sql = "insert into aircrafts (registrationNumber,name,type,capacity, manufacturer, cruiseSpeed)values ('" + registrationNumber + "','" + name + "','" + type + "','" + capacity + "','" + manufacturer + "', '" + cruiseSpeed + "')";
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


            public bool update(int id, string name, string type, string registrationNumber, int capacity, string manufacturer, int cruiseSpeed)
            {
                try
                {
                    connection.Open();
                    var sql = "update aircrafts set name ='" + name + "',type='" + type + "',capacity='" + capacity + "',registrationNumber='" + registrationNumber + "', manufacturer='" + manufacturer + "', cruiseSpeed='" + cruiseSpeed + "' where id='" + id + "'";
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
                    var sql = "select id, registrationNumber, name, type, capacity,  manufacturer, cruiseSpeed from aircrafts where registrationNumber = '" + registrationNumber + "'";
                    MySqlCommand command = new MySqlCommand(sql, connection);

                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {

                        int id = reader.GetInt32(0);
                        string name = reader.GetString(2);
                        string type = reader.GetString(3);
                        //string registrationNumber = reader.GetString(1);
                        int capacity = reader.GetInt32(4);
                        string manufacturer = reader.GetString(5);
                        int cruiseSpeed = reader.GetInt32(6);
                    aircraft = new Aircraft(id, name, type, registrationNumber, capacity,  manufacturer, cruiseSpeed);

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
                    Console.WriteLine($"{aircraft.getId()}, {aircraft.getRegistrationNumber()}, {aircraft.getName()}, {aircraft.getType()}, {aircraft.getCapacity()}, {aircraft.getManufacturer()}, {aircraft.getCruiseSpeed()}");
                }
            }

            public Aircraft findById(int id)
            {
                Aircraft aircraft = null;
                try
                {
                    connection.Open();
                    var sql = "select id, registrationNumber, name, type, capacity, manufacturer, cruiseSpeed from aircrafts where id = '" + id + "'";
                    MySqlCommand command = new MySqlCommand(sql, connection);

                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {

                        // int id = reader.GetInt32(0);
                        string name = reader.GetString(2);
                        string type = reader.GetString(3);
                        string registrationNumber = reader.GetString(1);
                        int capacity = reader.GetInt32(4);
                        string manufacturer = reader.GetString(5);
                        int cruiseSpeed = reader.GetInt32(6);
                    aircraft = new Aircraft(id, name, type, registrationNumber, capacity, manufacturer, cruiseSpeed);

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

            public int getCapacity(int id)
            {
                
                try
                {

                    connection.Open();
                    string sql = "SELECT capacity from aircrafts where id = '" + id + "'";

                    MySqlCommand command = new MySqlCommand(sql, connection);
                    MySqlDataReader reader = command.ExecuteReader();


                    if (reader.Read())
                    {
                        {
                            int capacity = reader.GetInt32(0);

                        return capacity;

                        }
                      
                    }
                }

                catch (MySqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                connection.Close();
                return 0;
            }

       }
}

