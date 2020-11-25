using System;
using System.Collections.Generic;
using System.Text;

namespace dockadmin
{

    public class Boat
    {
        public string BoatId { get; set; }
        public int Weight { get; set; }
        public double MaxSpeed { get; set; }
        public double BoatSize { get; set; }
        public int DaysToStay { get; set; }
    }

    public class SpeedBoat : Boat
    {
        public int HorsePower { get; set; }
        public SpeedBoat(string boatId, int weight, double maxSpeed, int horsePower, double boatSize, int daysToStay)
        {
            BoatId = boatId;
            Weight = weight;
            MaxSpeed = maxSpeed;
            HorsePower = horsePower; //10-10000
            DaysToStay = daysToStay;
            BoatSize = boatSize;
        }
    }

    public class SailBoat : Boat
    {
        public int BoatLength { get; set; }

        public SailBoat(string boatId, int weight, double maxSpeed, int boatLength, double boatSize, int daysToStay)
        {
            BoatId = boatId;
            Weight = weight;
            MaxSpeed = maxSpeed;
            BoatLength = boatLength; //10-60 foot
            DaysToStay = daysToStay;
            BoatSize = boatSize;
        }
    }

    public class FreightBoat : Boat
    {
        public int Containers { get; set; }
        public FreightBoat(string boatId, int weight, double maxSpeed, int containers, double boatSize, int daysToStay)
        {
            BoatId = boatId;
            Weight = weight;
            MaxSpeed = maxSpeed;
            Containers = containers; // 0-500 Containers
            DaysToStay = daysToStay;
            BoatSize = boatSize;
        }
    }
}
