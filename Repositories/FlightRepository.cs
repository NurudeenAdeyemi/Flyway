﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlywayAirlines.Repositories
{
    public class FlightRepository : IFlightRepository
    {
        MySqlConnection connection;
        IAircraftRepository aircraftManager;
        public FlightRepository (MySqlConnection connection)
        {
            this.connection = connection;
            aircraftManager = new AircraftRepository(connection);
        }
        public List<Flight> getAll()
        {
            List<Flight> flights = new List<Flight>();
            try
            {

                connection.Open();
                string sql = "SELECT id, flightNumber, aircraftid,takeOfPoint,landingTime,takeOfTime,destination,flightPrice from flights";

                MySqlCommand command = new MySqlCommand(sql, connection);
                MySqlDataReader reader = command.ExecuteReader();


                while (reader.Read())
                {
                    {

                        int id = reader.GetInt32(0);
                        int flightNumber = reader.GetInt32(1);
                        int aircraftid = reader.GetInt32(2);
                        string takeOfPoint = reader.GetString(3);
                        DateTime landingTime = reader.GetDateTime(4);
                        DateTime takeOfTime = reader.GetDateTime(5);
                        string destination = reader.GetString(6);
                        decimal flightPrice = reader.GetDecimal(7);
                        Flight flight = new Flight(id, flightNumber, aircraftid, takeOfPoint, landingTime, takeOfTime, destination, flightPrice);
                        flights.Add(flight);

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
            return flights;
        }

        public bool create(int flightNumber, int aircraftid, string takeOfPoint, DateTime landingTime, DateTime takeOfTime, string destination, decimal flightPrice)
        {
            Aircraft aircraft = aircraftManager.findById(aircraftid);
            if (aircraft == null)
            {
                Console.WriteLine($"Aircraft with {aircraftid} could not be found");
                return false;
            }
            try
            {
                connection.Open();
                string sql = "insert into flights (aircraftid,flightNumber, takeOfPoint,landingTime,takeOfTime,destination,flightPrice) values ('" + aircraftid + "','" + flightNumber + "','" + takeOfPoint + "','" + landingTime.ToString("yyyy-MM-dd HH:mm:ss") + "','" + takeOfTime.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + destination + "', '" + flightPrice + "')";
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

        public bool update(int id, int aircraftid, int flightNumber, string takeOfPoint, DateTime landingTime, DateTime takeOfTime, string destination, decimal flightPrice)
        {
            Aircraft aircraft = aircraftManager.findById(aircraftid);
            if (aircraft == null)
            {
                Console.WriteLine($"Aircraft with {aircraftid} could not be found");
                return false;
            }
            try
            {
                connection.Open();
                var sql = "update flights set aircraftid ='" + aircraftid + "',flightNumber = '" + flightNumber + "',takeOfPoint='" + takeOfPoint + "', landingTime='" + landingTime.ToString("yyyy-MM-dd HH:mm:ss") + "', takeOfTime='" + takeOfTime.ToString("yyyy-MM-dd HH:mm:ss") + "', destination='" + destination + "', flightPrice='" + flightPrice + "' where id = '" + id + "'";
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
                var sql = "delete from flights where id='" + id + "'";
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

        public Flight find(int flightNumber)
        {
            Flight flight = null;
            try
            {
                connection.Open();
                var sql = "select id, aircraftid, flightNumber, takeOfPoint,landingTime,takeOfTime,destination,flightPrice from flights where flightNumber = '" + flightNumber + "'";
                MySqlCommand command = new MySqlCommand(sql, connection);

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    int aircraftid = reader.GetInt32(1);
                    string takeOfPoint = reader.GetString(3);
                    DateTime landingTime = reader.GetDateTime(4);
                    DateTime takeOfTime = reader.GetDateTime(5);
                    string destination = reader.GetString(6);
                    decimal flightPrice = reader.GetDecimal(7);
                    flight = new Flight(id, aircraftid, flightNumber, takeOfPoint, landingTime, takeOfTime, destination, flightPrice);
                }

                Console.WriteLine(reader[0] + " -- " + reader[1]);
                //Console.WriteLine($"{flight.getId()}, {flight.getRegistrationNumber()}, {flight.getFlightNumber()}, {flight.getTakeOfPoint()}, {flight.getTakeOfTime()}, {flight.getLandingTime()}, {flight.getDestination()}, {flight.getFlightPrice()}");
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            connection.Close();
            return flight;
        }

        public void displayAll()
        {
            List<Flight> flights = getAll();
            foreach (Flight flight in flights)
            {
                Console.WriteLine($"{flight.getId()}, {flight.getAircraftid()}, {flight.getFlightNumber()}, {flight.getTakeOfPoint()}, {flight.getLandingTime()}, {flight.getTakeOfTime()}, {flight.getDestination()}, {flight.getFlightPrice()}");
            }
        }

        public Flight findById(int id)
        {
            Flight flight = null;
            try
            {
                connection.Open();
                var sql = "select id, aircraftid, flightNumber, takeOfPoint,landingTime,takeOfTime,destination,flightPrice from flights where id = '" + id + "'";
                MySqlCommand command = new MySqlCommand(sql, connection);

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    //int id = reader.GetInt32(0);
                    int aircraftid = reader.GetInt32(1);
                    int flightNumber = reader.GetInt32(2);
                    string takeOfPoint = reader.GetString(3);
                    DateTime landingTime = reader.GetDateTime(4);
                    DateTime takeOfTime = reader.GetDateTime(5);
                    string destination = reader.GetString(6);
                    decimal flightPrice = reader.GetDecimal(7);
                    flight = new Flight(id, aircraftid, flightNumber, takeOfPoint, landingTime, takeOfTime, destination, flightPrice);
                }

                Console.WriteLine(reader[0] + " -- " + reader[1]);
                //Console.WriteLine($"{flight.getId()}, {flight.getRegistrationNumber()}, {flight.getFlightNumber()}, {flight.getTakeOfPoint()}, {flight.getTakeOfTime()}, {flight.getLandingTime()}, {flight.getDestination()}, {flight.getFlightPrice()}");
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            connection.Close();
            return flight;
        }

        public List<Flight> search(string source, string destination, DateTime departureDate)
        {
            List<Flight> flights = new List<Flight>();
            try
            {

                connection.Open();
                string sql = $"SELECT id, flightNumber, aircraftid,takeOfPoint,landingTime,takeOfTime,destination,flightPrice FROM flights WHERE takeOfPoint = '{source}' and destination = '{destination}' and date(takeOfTime) = date('{departureDate:yyyy-MM-dd}')";

                MySqlCommand command = new MySqlCommand(sql, connection);
                MySqlDataReader reader = command.ExecuteReader();


                while (reader.Read())
                {
                    {

                        int id = reader.GetInt32(0);
                        int flightNumber = reader.GetInt32(1);
                        int aircraftid = reader.GetInt32(2);
                        string takeOfPoint = reader.GetString(3);
                        DateTime landingTime = reader.GetDateTime(4);
                        DateTime takeOfTime = reader.GetDateTime(5);
                        decimal flightPrice = reader.GetDecimal(7);
                        Flight flight = new Flight(id, flightNumber, aircraftid, takeOfPoint, landingTime, takeOfTime, destination, flightPrice);
                        flights.Add(flight);

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
            return flights;
        }

       

            
    }
}
