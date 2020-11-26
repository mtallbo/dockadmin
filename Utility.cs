using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dockadmin
{
    public class Utility
    {
        private readonly Random _rnd;
        public Utility()
        {
            _rnd = new Random();
        }
        public Boat GenerateRandomBoat()
        {
            int TypeOfBoatToGenerate = _rnd.Next(1, 4);
            if (TypeOfBoatToGenerate == 1)
            {
                return CreateSpeedBoat();
            }
            if (TypeOfBoatToGenerate == 2)
            {
                return CreateSailBoat();
            }
            if (TypeOfBoatToGenerate == 3)
            {
                return CreateFreightBoat();
            }
            return null;
        }
        public List<Boat> GenerateRandomBoat(int amountOfBoatsToGenerate)
        {
            List<Boat> randomBoats = new List<Boat>();
            for (int i = 0; i < amountOfBoatsToGenerate; i++)
            {
                int TypeOfBoatToGenerate = _rnd.Next(1, 4);
                if (TypeOfBoatToGenerate == 1)
                {
                    randomBoats.Add(CreateSpeedBoat());
                }
                if (TypeOfBoatToGenerate == 2)
                {
                    randomBoats.Add(CreateSailBoat());
                }
                if (TypeOfBoatToGenerate == 3)
                {
                    randomBoats.Add(CreateFreightBoat());
                }
            }
            return randomBoats;
        }
        public SpeedBoat CreateSpeedBoat()
        {
            SpeedBoat boat = new SpeedBoat(
                boatId: $"M-{RandomSuffix()}",
                weight: _rnd.Next(200, 3000),
                maxSpeed: _rnd.Next(1, 60),
                horsePower: _rnd.Next(10, 10000),
                boatSize: 1,
                daysToStay: 3
            );
            return boat;
        }

        public SailBoat CreateSailBoat()
        {
            SailBoat boat = new SailBoat(
                boatId: $"S-{RandomSuffix()}",
                weight: _rnd.Next(800, 6000),
                maxSpeed: _rnd.Next(1, 12),
                boatLength: _rnd.Next(10, 60),
                boatSize: 2,
                daysToStay: 4
            );
            return boat;
        }

        public FreightBoat CreateFreightBoat()
        {
            FreightBoat boat = new FreightBoat(
                boatId: $"L-{RandomSuffix()}",
                weight: _rnd.Next(3000, 20000),
                maxSpeed: _rnd.Next(1, 20),
                containers: _rnd.Next(0, 500),
                boatSize: 4,
                daysToStay: 6
            );
            return boat;
        }
        private string RandomSuffix()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return new string(Enumerable.Repeat(chars, 3)
              .Select(s => s[_rnd.Next(s.Length)]).ToArray());
        }
    }
}
