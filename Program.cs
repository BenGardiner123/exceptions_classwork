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

        //need to break this into a function
        
        System.Console.WriteLine("Before you go into this room person 1 tell me your name: John Doe or Jane Black ?");
        string userInput = Console.ReadLine();
        identityAssist(userInput);
        System.Console.WriteLine($"{p1.Name} which room wil you enter? TD224 or AGSE111?");
        string user1RoomInput = Console.ReadLine();
        
        
        if (user1RoomInput == "TD224" && r1.isRoomEmpty())
        {
            try{
                r1.enterRoom(p1);
            }
            catch (NullReferenceException ex){
                System.Console.WriteLine($"Sorry there was s serious problem due to {ex.Message} -- shutting down ");
            }
            
            System.Console.WriteLine("Please enter the date you are entering? like this e.g. 05/05/2005");
            string userDateInput = Console.ReadLine();

            try{
               p1.setDate(userDateInput);
            }
            catch (ArgumentException ex){
                System.Console.WriteLine($"Sorry there was s serious problem due to {ex.Message} -- shutting down ");
            }

            try{
               System.Console.WriteLine($"{p1.Name} How long will you stay 12, 15, or 300 minutes");
               string lengthOfStay = Console.ReadLine();
               p1.stayHowLong(lengthOfStay);
            }
            catch (ArgumentException ex){
                System.Console.WriteLine($"Sorry there was s serious problem due to {ex.Message} -- shutting down ");
            }

            
        }
        else if (user1RoomInput == "AGSE111" && r2.isRoomEmpty())
        {
             try{
                r2.enterRoom(p1);
            }
            catch (NullReferenceException ex){
                System.Console.WriteLine($"Sorry there was s serious problem due to {ex.Message} -- shutting down ");
            }
            
            System.Console.WriteLine("Please enter the date you are entering? like this e.g. 05/05/2005");
            string userDateInput = Console.ReadLine();

            try{
               p1.setDate(userDateInput);
            }
            catch (ArgumentException ex){
                System.Console.WriteLine($"Sorry there was s serious problem due to {ex.Message} -- shutting down ");
            }
            try{
               System.Console.WriteLine($"{p1.Name} How long will you stay 12, 15, or 300 minutes");
               string lengthOfStay = Console.ReadLine();
               p1.stayHowLong(lengthOfStay);
            }
            catch (ArgumentException ex){
                System.Console.WriteLine($"Sorry there was s serious problem due to {ex.Message} -- shutting down ");
            }

         
        }       
           
        if(r1.isRoomEmpty()){
            System.Console.WriteLine($"{p2.Name} TD224 is free ... in you go..");
            try{
                r1.enterRoom(p2);
            }
            catch (NullReferenceException ex){
                System.Console.WriteLine($"Sorry there was s serious problem due to {ex.Message} -- shutting down ");
            }
            
            System.Console.WriteLine("Please enter the date you are entering? like this e.g. 05/05/2005");
            string userDateInput = Console.ReadLine();

            try{
               p2.setDate(userDateInput);
            }
            catch (ArgumentException ex){
                System.Console.WriteLine($"Sorry there was s serious problem due to {ex.Message} -- shutting down ");
            }
            try{
               System.Console.WriteLine($"{p2.Name} How long will you stay 12, 15, or 300 minutes");
               string lengthOfStay = Console.ReadLine();
               p2.stayHowLong(lengthOfStay);
            }
            catch (ArgumentException ex){
                System.Console.WriteLine($"Sorry there was s serious problem due to {ex.Message} -- shutting down ");
            }
            
             
        }
        else 
        {
            System.Console.WriteLine($"{p2.Name} AGSE111 is free ... in you go..");
            try{
                r2.enterRoom(p2);
            }
            catch (NullReferenceException ex){
                System.Console.WriteLine($"Sorry there was s serious problem due to {ex.Message} -- shutting down ");
            }
            
            System.Console.WriteLine("Please enter the date you are entering? like this e.g. 05/05/2005");
            string userDateInput = Console.ReadLine();

            try{
               p1.setDate(userDateInput);
            }
            catch (ArgumentException ex){
                System.Console.WriteLine($"Sorry there was s serious problem due to {ex.Message} -- shutting down ");
            }
            try{
               System.Console.WriteLine($"{p2.Name} How long will you stay 12, 15, or 300 minutes");
               string lengthOfStay = Console.ReadLine();
               p2.stayHowLong(lengthOfStay);
            }
            catch (ArgumentException ex){
                System.Console.WriteLine($"Sorry there was s serious problem due to {ex.Message} -- shutting down ");
            }
            


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
            else if (userInput == "Jane Black")
                {
                    p1.addName(userInput);
                    p2.addName(person1);
                }

            System.Console.WriteLine($"Person 1's name is {p1.Name}");
            System.Console.WriteLine($"Person 2's name is {p2.Name}");

        }



        
        
        
        
        }

    }

}
