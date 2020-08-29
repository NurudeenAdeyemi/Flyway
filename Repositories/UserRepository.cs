using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace FlywayAirlines.Repositories
{
    public class UserRepository: IUserRepository
    {
        MySqlConnection connection;

        public UserRepository(MySqlConnection connection)
        {
            this.connection = connection;
        }

        public bool create(string firstName, string lastName, string email, string password)
        {
            try
            {
                connection.Open();
                string sql = "INSERT INTO users (firstName,lastName,email,password) VALUES ('" + firstName + "','" + lastName + "','" + email + "','" + password + "')";
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

        public User findById(int id)
        {
            User user = null;
            try
            {
                connection.Open();
                var sql = "SELECT id, firstName,lastName,email, password FROM users WHERE id = '" + id + "'";
                MySqlCommand command = new MySqlCommand(sql, connection);

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    string firstName = reader.GetString(1);
                    string lastName = reader.GetString(2);
                    string email = reader.GetString(3);
                    string password = reader.GetString(4);
                    user = new User(id, firstName, lastName, email, password);
                }
                Console.WriteLine(reader[0] + " -- " + reader[1]);
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            connection.Close();
            return user;
        }

        public User findByEmail(string email)
        {
            User user = null;
            try
            {
                connection.Open();
                var sql = "SELECT id, firstName,lastName,email, password FROM users WHERE email = '" + email + "'";
                MySqlCommand command = new MySqlCommand(sql, connection);

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    string firstName = reader.GetString(1);
                    string lastName = reader.GetString(2);
                    int id = reader.GetInt32(0);
                    string password = reader.GetString(4);
                    user = new User(id, firstName, lastName, email, password);
                }
                Console.WriteLine(reader[0] + " -- " + reader[1]);
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            connection.Close();
            return user;
        }


        public List<User> getAll()
        {
            List<User> users = new List<User>();
            try
            {

                connection.Open();
                string sql = "SELECT id, firstName, lastName,email,password FROM users";

                MySqlCommand command = new MySqlCommand(sql, connection);
                MySqlDataReader reader = command.ExecuteReader();


                while (reader.Read())
                {
                    {

                        int id = reader.GetInt32(0);
                        string firstName = reader.GetString(1);
                        string lastName = reader.GetString(2);
                        string email = reader.GetString(3);
                        string password = reader.GetString(4);

                        User user = new User(id, firstName, lastName, email, password);
                        users.Add(user);

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
            return users;
        }

        public bool remove(int id)
        {
            try
            {
                connection.Open();
                var sql = "DELETE FROM users WHERE id='" + id + "'";
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

        public bool update(int id, string firstName, string lastName, string email, string password)
        {
            try
            {
                connection.Open();
                var sql = "UPDATE users SET firstName ='" + firstName + "',lastName='" + lastName + "',email='" + email + "',password='" + password + "' WHERE id='" + id + "'";
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

        public User find(string email, string password)
        {
            User user = null;
            try
            {
                connection.Open();
                var sql = "SELECT id, firstName,lastName,email, password FROM users WHERE email = '" + email + "' and password = '" + password + "'";
                MySqlCommand command = new MySqlCommand(sql, connection);

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    string firstName = reader.GetString(1);
                    string lastName = reader.GetString(2);
                    int id = reader.GetInt32(0);
                    user = new User(id, firstName, lastName, email, password);
                }
                Console.WriteLine(reader[0] + " -- " + reader[1]);
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            connection.Close();
            return user;
        }
    }
}
