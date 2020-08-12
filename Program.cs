using System;

namespace exceptions_calsswork
{
    class Program
    {
        static void Main(string[] args)
        {
        DateTime FirstDate = new DateTime(2020, 8, 03, 14, 30, 0);
        DateTime SecondDate = new DateTime(2020, 2, 23, 8, 20, 0);
        TimeSpan stayed12 = new TimeSpan(0,0,12,0);
        TimeSpan stayed15 = new TimeSpan(0,0,15,0);
        TimeSpan stayed300 = new TimeSpan(0,0,300,0);

        Room r1 = new Room("TD224");
        Room r2 = new Room("AGSE111");
        Person p1 = new Person();
        Person p2 = new Person();

        System.Console.WriteLine("Before you go into this room please tell me your names : John Doe or Jane Black ?");
        string userInput = Console.ReadLine();

        try {

            if (userInput == "John Doe")
            {
                p1.addName(userInput);
                System.Console.WriteLine("Which room are you looking for TD224 or AGSE111 ?");
                string userRoomInput = Console.ReadLine();
                if (userRoomInput == "TD224")
                {
                    r1.enterRoom(p1);
                    p1.setDate(FirstDate);
                }
            }

        } catch (Exception ex) {
            System.Console.WriteLine($"Your input was not able to be understood or something else you did :( Closing Program - {ex.Message}");
        }
           
       

        }
    }

}
