using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlywayAirlines.Models;

namespace FlywayAirlines.Repositories
{
    public class BookingRepository : IBookingRepository
    {
        MySqlConnection connection;
        IFlightRepository flightManager;
        public BookingRepository(MySqlConnection connection)
        {
            this.connection = connection;
            flightManager = new FlightRepository(connection);
        }
        public List<Booking> getAll()
        {
            List<Booking> bookings = new List<Booking>();
            try
            {

                connection.Open();
                string sql = "SELECT id,bookingNumber,flightid, passengerid, bookingDate, bookingType, seatNumber from bookings";

                MySqlCommand command = new MySqlCommand(sql, connection);
                MySqlDataReader reader = command.ExecuteReader();


                while (reader.Read())
                {
                    {

                        int id = reader.GetInt32(0);
                        string bookingNumber = reader.GetString(1);
                        int flightid = reader.GetInt32(2);
                        int passengerid = reader.GetInt32(3);
                        DateTime bookingDate = reader.GetDateTime(4);
                        string bookingType = reader.GetString(5);
                        int seatNumber = reader.GetInt32(6);
                        Booking booking = new Booking(id, bookingNumber, flightid, passengerid, bookingDate, bookingType, seatNumber);
                        bookings.Add(booking);

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
            return bookings;
        }

        public bool create(string bookingNumber, int flightid, int passengerid, DateTime bookingDate, string bookingType, int seatNumber)
        {
            Flight flight = flightManager.findById(flightid);
            if (flight == null)
            {
                Console.WriteLine($"Flight with {flightid} could not be found");
                return false;
            }
            try
            {
                connection.Open();
                string sql = "insert into bookings (bookingNumber,flightid, passengerid, bookingDate, bookingType, seatNumber)values ('" + bookingNumber + "','" + flightid + "', '" + passengerid + "','" + bookingDate.ToString("yyyy-MM-dd") + "','" + bookingType + "', '" + seatNumber + "')";
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

        public bool update(int id, string bookingNumber, int flightid, int passengerid, DateTime bookingDate, string bookingType, int seatNumber)
        {
            Flight flight = flightManager.findById(flightid);
            if (flight == null)
            {
                Console.WriteLine($"Flight with {flightid} could not be found");
                return false;
            }
            try
            {
                connection.Open();
                var sql = "update bookings set flightid ='" + flightid + "', passengerid ='" + passengerid + "', bookingNumber='" + bookingNumber + "', bookingDate ='" + bookingDate.ToString("yyyy-MM-dd") + "', bookingType='" + bookingType + "', seatNumber='" + seatNumber + "' where id='" + id + "'";
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
                var sql = "delete from bookings where id='" + id + "'";
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

        public BookingSummary find(string bookingNumber)
        {
            BookingSummary booking = null;
            try
            {
                connection.Open();
                //var sql = "select id, bookingNumber,flightid, passengerid, bookingDate, bookingType, seatNumber, flight.flightNumber, passenger.firstName, passenger.lastName from bookings inner join flights where bookingNumber = '" + bookingNumber + "'";
                var sql = "select b.bookingDate, b.bookingType, b.seatNumber,f.flightNumber,f.flightPrice,f.landingTime,f.takeOfTime,p.firstName,p.lastName from flights f inner join bookings b on f.id=b.flightid join passengers p on p.id = b.passengerid where b.bookingNumber = '" + bookingNumber + "'";
                MySqlCommand command = new MySqlCommand(sql, connection);

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    DateTime bookingDate = reader.GetDateTime(0);
                    string bookingType = reader.GetString(1);
                    int seatNumber = reader.GetInt32(2);
                    int flightNumber = reader.GetInt32(3);
                    int flightprice = reader.GetInt32(4);
                    DateTime landingTime = reader.GetDateTime(5);
                    DateTime takeOfTime = reader.GetDateTime(6);
                    string firstName = reader.GetString(7);
                    string lastName = reader.GetString(8);
                    
                    booking = new BookingSummary(bookingNumber, bookingDate, bookingType, seatNumber, flightNumber, flightprice, takeOfTime, landingTime, firstName, lastName);
                }
                Console.WriteLine(reader[0] + " -- " + reader[1]);
                //Console.WriteLine($"{booking.getId()}, {booking.getBookingNumber()}, {booking.getFlightNumber()}, {booking.getBookingDate()}, {booking.getBookingType()}, {booking.getSeatNumber()}");
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            connection.Close();
            return booking;
        }

        public void displayAll()
        {
            List<Booking> bookings = getAll();
            foreach (Booking booking in bookings)
            {
                Console.WriteLine($"{booking.getId()}, {booking.getBookingNumber()}, {booking.getFlightid()}, {booking.getPassengerid()}, {booking.getBookingDate().ToString("yyyy-MM-dd")}, {booking.getBookingType()}, {booking.getSeatNumber()}");
            }
        }

        public Booking findById(int id)
        {
            Booking booking = null;
            try
            {
                connection.Open();
                var sql = "select id, bookingNumber,flightid, passengerid, bookingDate, bookingType, seatNumber from bookings where id = '" + id + "'";
                //var sql = "select flights.*,bookings.* from flights inner join bookings on flights.id = bookings.flightid where id = '" + id + "'";
                MySqlCommand command = new MySqlCommand(sql, connection);

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    //int id = reader.GetInt32(0);
                    string bookingNumber = reader.GetString(1);
                    int flightid = reader.GetInt32(2);
                    int passengerid = reader.GetInt32(3);
                    DateTime bookingDate = reader.GetDateTime(4);
                    string bookingType = reader.GetString(5);
                    int seatNumber = reader.GetInt32(6);
                    booking = new Booking(id, bookingNumber, flightid, passengerid, bookingDate, bookingType, seatNumber);
                }
                Console.WriteLine(reader[0] + " -- " + reader[1]);
                //Console.WriteLine($"{booking.getId()}, {booking.getBookingNumber()}, {booking.getFlightNumber()}, {booking.getBookingDate()}, {booking.getBookingType()}, {booking.getSeatNumber()}");
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            connection.Close();
            return booking;
        }

        public int bookingCount(int id)
        {

            try
            {

                connection.Open();
                string sql = "SELECT count(*) from booking where id = '" + id + "'";

                MySqlCommand command = new MySqlCommand(sql, connection);
                MySqlDataReader reader = command.ExecuteReader();


                if (reader.Read())
                {
                    {
                        int totalBooking = reader.GetInt32(0);

                        return totalBooking;

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
