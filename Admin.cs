using System;
using System.Collections.Generic;
using System.Text;

namespace dockadmin
{
    public class Admin
    {
        IDock _dock;

        public Admin(IDock dock)
        {
            _dock = dock;
        }
        public void ShowCurrenteDockStatus()
        {
            _dock.ShowCurrentDockStatus();
        }

        public void FindEmptySlotAndAddBoat(Boat boat)
        {
            
            var emptySlot = _dock.FindEmptySlot();
            if(emptySlot != null)
            {
                _dock.AddBoatToSlot(boat, (int)emptySlot);
            }
            //var boatWasAddded = _dock.AddBoatToSlot(boat, slotIndex);
            //if (boatWasAddded)
            //{
            //    return true;
            //} else
            //{
            //    return false;
            //}
        }
    }
}
