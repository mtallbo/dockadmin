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

            while(daysToSimulate > 0)
            {
                DockAdmin.ClearDeparturingBoats();
                Console.WriteLine("DAY: " + daysToSimulate);
                var rndBoat = utility.GenerateRandomBoat(5);
                
                foreach (var boat in rndBoat)
                {
                    DockAdmin.AddBoat(boat);
                }
                DockAdmin.ShowCurrenteDockStatus();
                DockAdmin.DecrementDaysToStayOnDockedBoats();
                daysToSimulate--;
                Console.ReadKey();
                Console.Clear();
            }
            Console.WriteLine("Simulation done");
        }
    }
}
