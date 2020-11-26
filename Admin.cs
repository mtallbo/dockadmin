using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dockadmin
{
    public class Admin
    {
        private readonly Dock Dock;
        List<Boat> RejectedBoats = new List<Boat>();

        public Admin(Dock dock)
        {
            Dock = dock;
        }
        public void ShowCurrenteDockStatus()
        {
            var dockedBoats = Dock.GetAllBoatsInDock();
            var emptySlots = 0;
            for (int i = 0; i < dockedBoats.Length; i++)
            {
                if (dockedBoats[i] == null)
                {
                    emptySlots++;
                    Console.WriteLine($"Slot{i}: empty");
                }
                else
                {
                    Console.WriteLine($"Slot{i}: {dockedBoats[i].BoatId}, Days left: {dockedBoats[i].DaysToStay}");
                }
            }
            Console.WriteLine($"Amount of rejected boats: {RejectedBoats.Count}");
            Console.WriteLine($"Amount of empty slots: {emptySlots}");
        }

        public void AddBoat(Boat boat)
        {
            //If a boat is rejected it will be returned below
            var rejectedBoat = Dock.FindEmptySlotAndAddBoat(boat);
            if (rejectedBoat != null)
            {
                RejectedBoats.Add(rejectedBoat);
            }
        }


        public List<Boat> ClearDeparturingBoats()
        {
            var dockedBoats = Dock.GetAllBoatsInDock();
            List<Boat> departuringBoats = new List<Boat>();
            for (int i = 0; i < dockedBoats.Length; i++)
            {
                if (dockedBoats[i] == null)
                {
                    continue;
                }
                if(dockedBoats[i].DaysToStay == 0)
                {
                    departuringBoats.Add(dockedBoats[i]);
                    Dock.RemoveBoatFromSlot(i);
                }
            }
            return departuringBoats;
        }

        public void DecrementDaysToStayOnDockedBoats()
        {
            var dock = Dock.GetAllBoatsInDock();
            var dockedBoats = dock.Distinct().ToList();

            foreach (var dockedBoat in dockedBoats)
            {
                if(dockedBoat == null)
                {
                    continue;
                }
                dockedBoat.DaysToStay--;
            }
        }
    }
}
