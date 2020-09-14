using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlywayAirlines
{
    public class Flight
    {
        private int id;
        private int flightNumber;
        private int aircraftid;
        private string takeOfPoint;
        private DateTime landingTime;
        private DateTime takeOfTime;
        private string destination;
        private decimal flightPrice;
        public Aircraft Aircraft;
        public List<Booking> Bookings = new List<Booking>();

        public Flight(int id, int flightNumber, int aircraftid, string takeOfPoint, DateTime landingTime, DateTime takeOfTime, string destination, decimal flightPrice)
        {
            this.id = id;
            this.flightNumber = flightNumber;
            this.aircraftid = aircraftid;
            this.takeOfPoint = takeOfPoint;
            this.landingTime = landingTime;
            this.takeOfTime = takeOfTime;
            this.destination = destination;
            this.flightPrice = flightPrice;
           
        }
        public void setId(int id)
        {
            this.id = id;
        }
        public int getId()
        {
            return id;
        }

        public void setAircraftid(int aircraftid)
        {
            this.aircraftid = aircraftid;
        }
        public int getAircraftid()
        {
            return aircraftid;
        }

        public void setFlightNumber(int flightNumber)
        {
            this.flightNumber = flightNumber;
        }
        public int getFlightNumber()
        {
            return flightNumber;
        }


        public void setTakeOfPoint(string takeOfPoint)
        {
            this.takeOfPoint = takeOfPoint;
        }
        public string getTakeOfPoint()
        {
            return takeOfPoint;
        }


        public void setLandingTime(DateTime landingTime)
        {
            this.landingTime = landingTime;
        }
        public DateTime getLandingTime()
        {
            return landingTime;
        }

        public void setTakeOfTime(DateTime takeOfTime)
        {
            this.takeOfTime = takeOfTime;
        }
        public DateTime getTakeOfTime()
        {
            return takeOfTime;
        }


        public void setDestination(string destination)
        {
            this.destination = destination;
        }
        public string getDestination()
        {
            return destination;
        }

        public void setFlightPrice(decimal flightPrice)
        {
            this.flightPrice = flightPrice;
        }
        public decimal getFlightPrice()
        {
            return flightPrice;
        }

        public override string ToString()
        {
            return $"{id}\t{aircraftid}\t{takeOfPoint}\t{landingTime}\t{takeOfTime}\t{destination}\t{flightPrice}";
        }
    }
}
