using System;

namespace dockadmin
{
    class Program
    {
        //Set days to simulate
        static void Main()
        {
            Admin DockAdmin = new Admin(new Dock());
            Utility utility = new Utility();
            
            int daysToSimulate = 30;
            
            
            
            var rndBoat= utility.GenerateRandomBoat();
            var freightBoat1 = utility.CreateFreightBoat();
            var freightBoat2 = utility.CreateFreightBoat();

            var freightBoat3 = utility.CreateFreightBoat();

            var speedBoat1 = utility.CreateSpeedBoat();
            //DockAdmin.AddBoatToDock(boat1, 0);
            DockAdmin.FindEmptySlotAndAddBoat(freightBoat1);
            DockAdmin.FindEmptySlotAndAddBoat(freightBoat2);
            DockAdmin.FindEmptySlotAndAddBoat(freightBoat3);
            DockAdmin.FindEmptySlotAndAddBoat(speedBoat1);
            DockAdmin.FindEmptySlotAndAddBoat(rndBoat);

            DockAdmin.ShowCurrenteDockStatus();
            //while (daysToSimulate > 0)
            //{


            //}
        }
    }
}
