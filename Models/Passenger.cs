using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlywayAirlines
{
    public class Passenger
    {
        private int id;
        private string firstName;
        private string lastName;
        private string phoneNumber;
        private string email;
        private string gender;
        private DateTime dateOfBirth;
        public List<Booking> Bookings = new List<Booking>();
        public Passenger(int id, string firstName, string lastName, string phoneNumber, string email, string gender, DateTime dateOfBirth)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.gender = gender;
            this.dateOfBirth = dateOfBirth;
        }

        public void setId(int id)
        {
            this.id = id;
        }
        public int getId()
        {
            return id;
        }

        public void setFirstName(string firstName)
        {
            this.firstName = firstName;
        }
        public string getFirstName()
        {
            return firstName;
        }

        public void setLastName(string lastName)
        {
            this.lastName = lastName;
        }
        public string getLastName()
        {
            return lastName;
        }


        public void setPhoneNumber(string phoneNumber)
        {
            this.phoneNumber = phoneNumber;
        }
        public string getPhoneNumber()
        {
            return phoneNumber;
        }

        public void setEmail(string email)
        {
            this.email = email;
        }
        public string getEmail()
        {
            return email;
        }

        public void setGender(string gender)
        {
            this.gender = gender;
        }
        public string getGender()
        {
            return gender;
        }

        public void setDateOfBirth(DateTime dateOfBirth)
        {
            this.dateOfBirth = dateOfBirth;
        }
        public DateTime getDateOfBirth()
        {
            return dateOfBirth;
        }

        public override string ToString()
        {
            return $"{id}\t{firstName}\t{lastName}\t{phoneNumber}\t{Bookings}\t{email}\t{gender}\t{dateOfBirth}";
        }
    }
}
