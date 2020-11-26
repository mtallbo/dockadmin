using System;
using System.Collections.Generic;
using System.Text;

namespace dockadmin
{
    public class Dock
    {
        private Boat[] CurrentSlots = new Boat[24];

        public Boat FindEmptySlotAndAddBoat(Boat boat)
        {
            for (int slot = 0; slot < CurrentSlots.Length; slot++)
            {
                if (CurrentSlots[slot] == null)
                {
                    bool boatWillFit = WillBoatFitSlot(slot, boat.BoatSize);
                    if (boatWillFit)
                    {
                        AddBoatToSlot(boat, slot);
                        return null;
                    }
                }
            }
            return boat;
        }
        public Boat[] GetAllBoatsInDock()
        {
            return CurrentSlots;
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
            if (startIndex + sizeOfBoat > CurrentSlots.Length)
            {
                return false;
            }
            int emptySlots = 0;
            for (int i = startIndex; i < startIndex + sizeOfBoat; i++)
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
    }
}
