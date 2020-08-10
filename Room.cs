using System;
using System.Collections.Generic;

namespace exceptions_calsswork
{
    class Room
    {
        //attributes
        public string RoomNumber;
        public List<Person> ListOfPeopleInside = new List<Person>();

        
        ///ctor
        public Room(string roomid)
        {
            this.RoomNumber = roomid;
            

        }

        public void enterRoom(Person name)
        {
            this.ListOfPeopleInside.Add(name);
            
            name.DateAndTimeEntered = DateTime.Now;
            
        }

        public void leaveRoom(Person name)
        {
            name.DateAndTimeOfExit = DateTime.Now;
            this.ListOfPeopleInside.Remove(name);
        }
    }

}
