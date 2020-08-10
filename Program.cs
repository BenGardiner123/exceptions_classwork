using System;

namespace exceptions_calsswork
{
    class Program
    {
        static void Main(string[] args)
        {
        DateTime FirstDate = new DateTime(2020, 8, 03, 14, 30, 0);
        DateTime SecondDate = new DateTime(2020, 2, 23, 8, 20, 0);

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
            if (userInput == "Jane Black")
            {
                p2.addName(userInput);
                System.Console.WriteLine("Which room are you looking for TD224 or AGSE111 ?");
                string userRoomInput = Console.ReadLine();
                if (userRoomInput == "TD224")
                {
                    r1.enterRoom(p2);
                    p1.setDate(SecondDate);
                }
                
            }

        } catch (FormatException ex) {
            System.Console.WriteLine($"Your input was not able to be understood :( Closing Program - {ex.Message}");
        } catch (NullReferenceException ex) {
            System.Console.WriteLine($"Object doesn't exist :( Closing Program - {ex.Message}");
        } catch (Exception ex) {
            System.Console.WriteLine($"Something went wrong :( Closing Program - {ex.Message}");
        } finally {
            System.Console.WriteLine("!!!Finally block!!!");
        }

        System.Console.WriteLine("Are you both ready to leave the room?");
        
        try {
        
        
            
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

}
