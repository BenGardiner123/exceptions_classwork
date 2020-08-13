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
            try
            {    
                if (!this.ListOfPeopleInside.Contains(name))
                {
                    this.ListOfPeopleInside.Add(name);
                    name.DateAndTimeEntered = DateTime.Now;
                }
            }
            catch (Exception ex) 
            {
                System.Console.WriteLine($"Something went wrong :( Closing Program - {ex.Message}");
            }
            return;
            
        }

        public void leaveRoom(Person name)
        {
           try
           {
                if (this.ListOfPeopleInside.Contains(name))
                {
                    name.DateAndTimeOfExit = DateTime.Now;
                    this.ListOfPeopleInside.Remove(name);
                }
           }
           catch (Exception ex) 
           {
                System.Console.WriteLine($"Something went wrong :( Closing Program - {ex.Message}");
           }
        
            return; 
            
        }

        public bool isRoomEmpty()
        {
            bool empty = false;
            if (this.ListOfPeopleInside.Count == 0)
            {
                empty = true;
            }
            return empty;
        }
            
    }

}
