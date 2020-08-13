using System;

namespace exceptions_calsswork
{
    class Program
    {
        static void Main(string[] args)
        {
        DateTime FirstDate = new DateTime(2020, 8, 03, 14, 30, 0);
        DateTime SecondDate = new DateTime(2020, 2, 23, 8, 20, 0);
<<<<<<< HEAD
    
=======
        TimeSpan stayed12 = new TimeSpan(0,0,12,0);
        TimeSpan stayed15 = new TimeSpan(0,0,15,0);
        TimeSpan stayed300 = new TimeSpan(0,0,300,0);

>>>>>>> 4b2c897424a2805d50385c7324649b1f4e3f412e
        Room r1 = new Room("TD224");
        Room r2 = new Room("AGSE111");
        Person p1 = new Person();
        Person p2 = new Person();


        System.Console.WriteLine("Before you go into this room person 1 tell me your name: John Doe or Jane Black ?");
        string userInput = Console.ReadLine();
        identityAssist(userInput);
        System.Console.WriteLine($"{p1.Name} which room wil you enter? TD224 or AGSE111?");
        string user1RoomInput = Console.ReadLine();
        
        
        if (user1RoomInput == "TD224" && r1.isRoomEmpty())
        {
            r1.enterRoom(p1);
            p1.setDate(FirstDate);
        }
        else if (user1RoomInput == "AGSE111" && r2.isRoomEmpty())
        {
            r2.enterRoom(p1);
            p1.setDate(FirstDate);
        }       
           
        System.Console.WriteLine($"{p2.Name} which room wil you enter TD224 or AGSE111?");
        string user2RoomInput = Console.ReadLine();
        
        if (user2RoomInput == "TD224" && r1.isRoomEmpty())
        {
            r1.enterRoom(p2);
            p2.setDate(SecondDate);
        }
        else if (user2RoomInput == "AGSE111" && r2.isRoomEmpty())
        {
            r2.enterRoom(p2);
            p2.setDate(SecondDate);
        }      
        









        void identityAssist(string userInput)
        {
            string person1 = "John Doe";
            string person2 = "Jane Black";

            if (userInput == "John Doe")
                {
                    p1.addName(userInput);
                    p2.addName(person2);
                }
<<<<<<< HEAD
            else if (userInput == "Jane Black")
                {
                    p1.addName(userInput);
                    p2.addName(person1);
                }

            System.Console.WriteLine($"Person 1's name is {p1.Name}");
            System.Console.WriteLine($"Person 2's name is {p2.Name}");

        }



        
        
        
        
=======
            }

        } catch (Exception ex) {
            System.Console.WriteLine($"Your input was not able to be understood or something else you did :( Closing Program - {ex.Message}");
>>>>>>> 4b2c897424a2805d50385c7324649b1f4e3f412e
        }
           
       


    }

}
