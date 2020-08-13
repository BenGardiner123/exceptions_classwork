using System;

namespace exceptions_calsswork
{
    class Person
    {
        //attributes
        public string Name;
        public DateTime DateAndTimeEntered;

        public DateTime DateAndTimeOfExit;
        public DateTime timeSpentinRoom;

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
        public void setDate(DateTime userInput){
            this.DateAndTimeEntered = userInput;
        }


    }

}
