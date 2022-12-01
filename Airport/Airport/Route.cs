using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport
{
    internal class Route
    {
        public int Passenger { get; set; }

        public string BagsAmount { get; set; }

        public string BagsWeight { get; set; }
        public string FlightNumber { get; set; }
        public string DepartureTime { get; set; }
        public string FlightHours { get; set; }

        public string Destination { get; set; }
        public int V1 { get; }
        public string V2 { get; }
        public int V3 { get; }
        public int V4 { get; }
        public int V5 { get; }
        public int V6 { get; }
        public int V7 { get; }
        public int V8 { get; }
        public int V9 { get; }
        public int V10 { get; }
        public string V11 { get; }

        public Route (int passenger, string amount, int v, int v1, int v2, string weight, string number, string time, string hours, string destination)
        {
            Passenger = passenger;
            BagsAmount = amount;
            BagsWeight = weight;
            FlightNumber = number;
            DepartureTime = time;
            FlightHours = hours;
            Destination = destination;
        }

        public Route(int v1, string v2, int v3, int v4, int v5, int v6, int v7, int v8, int v9, int v10, string v11)
        {
            V1 = v1;
            V2 = v2;
            V3 = v3;
            V4 = v4;
            V5 = v5;
            V6 = v6;
            V7 = v7;
            V8 = v8;
            V9 = v9;
            V10 = v10;
            V11 = v11;
        }

        public override string ToString()
        {
            return Passenger.ToString() + "                                 |          " + BagsAmount.ToString() + "               |       " + BagsWeight.ToString() + "                             |       " + FlightNumber.ToString()               + "       |      " + DepartureTime.ToString()    + FlightHours.ToString() + Destination.ToString();
        }
    }
}
