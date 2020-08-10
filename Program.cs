using System;
using System.Collections.Generic;

namespace exceptions_calsswork
{
    class Program
    {
        static void Main(string[] args)
        {
            
        Building b1 = new Building("The Conservatory");
        Building b2 = new Building("The Meat Factory");
        Room r1 = new Room("CNSVR101");
        Room r2 = new Room("CNSVR201");
        Person p1 = new Person("Mirco Cro-Cop");
        Person person2 = new Person("Anderson Silva");

        System.Console.WriteLine("Please enter the room");

        try {
               p1.enterRoom(r1);
               b1.addRoom(r1);


                //throw new NullReferenceException();

            } catch (FormatException ex) {
                System.Console.WriteLine($"Input can't be converted to an integer :( Closing Program - {ex.Message}");
                //System.Environment.Exit(1);
            } catch (NullReferenceException ex) {
                System.Console.WriteLine($"Object doesn't exist :( Closing Program - {ex.Message}");
                //System.Environment.Exit(1);
            } catch (Exception ex) {
                System.Console.WriteLine($"Something went wrong :( Closing Program - {ex.Message}");
                //System.Environment.Exit(1);
            } finally {
                
                System.Console.WriteLine("!!!Finally block!!!");
            }


        }
    }

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

    class Person
    {
        //attributes
        public string Name;
        public DateTime DateAndTimeEntered;

        public DateTime DateAndTimeOfExit;
        public DateTime timeSpentinRoom;

        //ctor
        public Person(string name)
        {
            Name = name;
        }

      


    }

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

    class Outside
    {
        List <Person> RoomsList = new List<Person>();

        public Outside()
        {

        }


    }

}
