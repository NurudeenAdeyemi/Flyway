using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlywayAirlines
{
    public class Aircraft
    {
        //instance variables or parameters
        private int id;
        private int capacity;
        private string registrationNumber;
        private string type;
        private string name;
        private string manufacturer;
        private int cruiseSpeed;
        

        public Aircraft(int id, string name, string type, string registrationNumber, int capacity, string manufacturer, int cruiseSpeed) //constructor is a method used to instantiate the object , has the same name as the class
        {
            //(this) is a special keyword and a reference to the current instance of the class
            this.id = id;
            this.name = name;
            this.type = type;
            this.capacity = capacity;
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
            return $"{id}\t{registrationNumber}\t{name}\t{type}\t{capacity}\t{manufacturer}\t{cruiseSpeed}";
        }
    }
}

