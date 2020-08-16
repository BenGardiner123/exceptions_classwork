using System;

namespace exceptions_calsswork
{
    class Person
    {
        //attributes
        public string Name;
        public DateTime DateAndTimeEntered;

        public DateTime realDateTimeEntered;

        public DateTime DateAndTimeOfExit;
        public TimeSpan timeSpentinRoom;

        //ctor
        public Person()
        {
            
        }

        public void addName(string userInput){
            
            if (this.Name == null)
            {
                this.Name = userInput;
            }
            else
            {
                System.Console.WriteLine("This person already has a name");
            }
            
        }
        public void setDate(string userInput){
            DateTime userDate = new DateTime();

            try{
                userDate = Convert.ToDateTime(userInput);
                
            }
            catch(FormatException ex)
            {
                System.Console.WriteLine($"{ex}uh oh..please enter a date");
            }
            userDate = this.DateAndTimeEntered;

            
        }

        public void stayHowLong(string userInput)
        {   
            TimeSpan Time = new TimeSpan();
            Time = TimeSpan.Parse(userInput);
            
            this.timeSpentinRoom = Time;
        }
        

    }

}
