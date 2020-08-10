using System.Collections.Generic;

namespace exceptions_calsswork
{
    class Building
    {
        //ctor
        public string buildingName;
        List <Room> RoomsList = new List<Room>();

        public Building(string Name)
        {
            this.buildingName = Name;
            
        }

        public void addRoom(Room roomID)
        {
            RoomsList.Add(roomID);
        }

        
    }

}
