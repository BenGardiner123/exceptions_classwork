
using System;
using System.Collections.Generic;
using System.Linq;

namespace exceptions_calsswork
{
    class Person
    {
        //attributes
        public string Name;
        public DateTime realDateTimeEntered;

        public DateTime DateAndTimeEntered ;
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
            userDate = DateTime.Parse(userInput);
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
