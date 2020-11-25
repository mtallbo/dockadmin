using System;
using System.Collections.Generic;
using System.Text;

namespace dockadmin
{
    public class Dock : IDock
    {
        private Boat[] CurrentSlots = new Boat[63];

        public void FindEmptySlotAndAddBoat(Boat boat)
        {
            int? emptySlotAvailable = FindEmptySlot();
            if (emptySlotAvailable != null)
            {
                bool boatWillFit = WillBoatFitSlot((int)emptySlotAvailable, boat.BoatSize);
                if (boatWillFit)
                {
                    AddBoatToSlot(boat, (int)emptySlotAvailable);
                }
            }
        }

        public void ShowCurrentDockStatus()
        {
            for (int i = 0; i < CurrentSlots.Length; i++)
            {
                Console.WriteLine($"Slot{i}: {CurrentSlots[i]}");
            }
        }
        public void RemoveBoatFromSlots(Boat boat)
        {
            throw new NotImplementedException();
        }

        private int? FindEmptySlot()
        {
            for (int slotIndex = 0; slotIndex < CurrentSlots.Length; slotIndex++)
            {
                if (CurrentSlots[slotIndex] == null)
                {
                    Console.WriteLine("Found empty slot @ : " + slotIndex);
                    return slotIndex;
                }
            }
            //Return null if no empty slots
            return null;
        }
        private void AddBoatToSlot(Boat boat, int startSlotIndex)
        {
            for (int i = 0; i < boat.BoatSize; i++)
            {
                CurrentSlots[startSlotIndex + i] = boat;
            }
        }

        private bool WillBoatFitSlot(int startIndex, double sizeOfBoat)
        {
            int emptySlots = 0;
            for (int i = startIndex; i < sizeOfBoat; i++)
            {
                //Slot is occupied
                if (CurrentSlots[i] != null)
                {
                    return false;
                }
                emptySlots++;
            }
            //Count how many adjecant slots are available and see if it matches the size of the boat
            if (emptySlots == sizeOfBoat)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool IsSlotAvailable(int slot)
        {
            if (CurrentSlots[slot] == null)
            {
                return true;
            }
            else
            {
                Console.WriteLine($"{slot} is not available");
                return false;
            }
        }
    }
}
