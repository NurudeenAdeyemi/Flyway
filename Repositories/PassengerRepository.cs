using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlywayAirlines.Repositories
{
    public class PassengerRepository : IPassengerRepository
    {
        MySqlConnection connection;
        IBookingRepository bookingRepository;
        public PassengerRepository(MySqlConnection connection)
        {
            this.connection = connection;
            bookingRepository = new BookingRepository(connection);
        }
        public List<Passenger> getAll()
        {
            List<Passenger> passengers = new List<Passenger>();
            try
            {

                connection.Open();
                string sql = "SELECT id,firstName,lastName,phoneNumber,email, gender, dateOfBirth from passengers";

                MySqlCommand command = new MySqlCommand(sql, connection);
                MySqlDataReader reader = command.ExecuteReader();


                while (reader.Read())
                {
                    {

                        int id = reader.GetInt32(0);
                        string firstName = reader.GetString(1);
                        string lastName = reader.GetString(2);

                        string phoneNumber = reader.GetString(3);
                        string email = reader.GetString(4);
                        string gender = reader.GetString(5);
                        DateTime dateOfBirth = reader.GetDateTime(6);
                        Passenger passenger = new Passenger(id, firstName, lastName, phoneNumber, email, gender, dateOfBirth);
                        passengers.Add(passenger);

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
            return passengers;
        }

        public int create(string firstName,  string lastName, string phoneNumber, string email, string gender, DateTime dateOfBirth)
        {
            
            try
            {
                connection.Open();
                string sql = "insert into passengers (firstName,lastName,phoneNumber,email, gender, dateOfBirth) values ('" + firstName + "', '" + lastName + "','" + phoneNumber + "','" + email + "', '" + gender + "','" + dateOfBirth.ToString("yyyy-MM-dd") + "')";
                MySqlCommand command = new MySqlCommand(sql, connection);
                int count = command.ExecuteNonQuery();
                if (count > 0)
                {
                    var id = command.LastInsertedId;
                    connection.Close();
                    return (int)id;
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            connection.Close();
            return -1;
        }

        public bool update(int id, string firstName, string lastName, string phoneNumber, string email, string gender, DateTime dateOfBirth)
        {
            
            try
            {
                connection.Open();
                var sql = "update passengers set firstName='" + firstName + "', lastName='" + lastName + "', phoneNumber='" + phoneNumber + "', email='" + email + "', gender='" + gender + "', dateOfBirth='" + dateOfBirth.ToString("yyyy-MM-dd") + "' where id='" + id + "'";
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
                var sql = "delete from passengers where id='" + id + "'";
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

        public Passenger find(string lastName)
        {
            Passenger passenger = null;
            try
            {
                connection.Open();
                var sql = "select id, firstName,lastName,phoneNumber,email, gender, dateOfBirth from passengers where lastName = '" + lastName+ "'";
                MySqlCommand command = new MySqlCommand(sql, connection);

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string firstName = reader.GetString(1);

                    string phoneNumber = reader.GetString(3);
                    string email = reader.GetString(4);
                    string gender = reader.GetString(5);
                    DateTime dateOfBirth = reader.GetDateTime(6);
                    passenger = new Passenger(id, firstName, lastName, phoneNumber, email, gender, dateOfBirth);
                }
                Console.WriteLine(reader[0] + " -- " + reader[1]);
                //Console.WriteLine($"{passenger.getId()}, {passenger.getName()}, {passenger.getBookingNumber()}, {passenger.getAddress()}, {passenger.getPhoneNumber()}, {passenger.getEmail()},  {passenger.getGender()}, {passenger.getDateOfBirth()}");
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            connection.Close();
            return passenger;
        }

        public void displayAll()
        {
            List<Passenger> passengers = getAll();
            foreach (Passenger passenger in passengers)
            {
                Console.WriteLine($"{passenger.getId()}, {passenger.getFirstName()}, {passenger.getLastName()}, {passenger.getPhoneNumber()}, {passenger.getEmail()},  {passenger.getGender()}, {passenger.getDateOfBirth()}");
            }
        }

        public Passenger findById(int id)
        {
            Passenger passenger = null;
            try
            {
                connection.Open();
                var sql = "select id, firstName,lastName,phoneNumber,email, gender, dateOfBirth from passengers where id = '" + id + "'";
                MySqlCommand command = new MySqlCommand(sql, connection);

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    //int id = reader.GetInt32(0);
                    
                    string firstName = reader.GetString(1);
                    string lastName = reader.GetString(2);

                    string phoneNumber = reader.GetString(3);
                    string email = reader.GetString(4);
                    string gender = reader.GetString(5);
                    DateTime dateOfBirth = reader.GetDateTime(6);
                    passenger = new Passenger(id, firstName, lastName, phoneNumber, email, gender, dateOfBirth);
                }
                Console.WriteLine(reader[0] + " -- " + reader[1]);
                //Console.WriteLine($"{passenger.getId()}, {passenger.getName()}, {passenger.getBookingNumber()}, {passenger.getAddress()}, {passenger.getPhoneNumber()}, {passenger.getEmail()},  {passenger.getGender()}, {passenger.getDateOfBirth()}");
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            connection.Close();
            return passenger;
        }
    }
}
