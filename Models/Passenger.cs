using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlywayAirlines
{
    public class Passenger
    {
        private int id;
        private int bookingid;
        private string firstName;
        private string lastName;
        private string address;
        private double phoneNumber;
        private string email;
        private string gender;
        private DateTime dateOfBirth;
        public Passenger(int id, string firstName, string lastName, int bookingid, string address, double phoneNumber, string email, string gender, DateTime dateOfBirth)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.bookingid = bookingid;
            this.address = address;
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

        public void setBookingid(int bookingid)
        {
            this.bookingid = bookingid;
        }
        public int getBookingid()
        {
            return bookingid;
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

        public void setAddress(string address)
        {
            this.address = address;
        }
        public string getAddress()
        {
            return address;
        }

        public void setPhoneNumber(double phoneNumber)
        {
            this.phoneNumber = phoneNumber;
        }
        public double getPhoneNumber()
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
            return $"{id}\t{firstName}\t{lastName}\t{bookingid}\t{phoneNumber}\t{address}\t{email}\t{gender}\t{dateOfBirth}";
        }
    }
}
