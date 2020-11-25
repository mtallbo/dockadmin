using System;
using System.Collections.Generic;
using System.Text;

namespace dockadmin
{
    public interface IDock
    {
        int? FindEmptySlot();
        void AddBoatToSlot(Boat boat, int slot);
        void RemoveBoatFromSlot(Boat boat);
        void ShowCurrentDockStatus();
    }
}
