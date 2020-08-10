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
            this.Name = userInput;
        }
        public void setDate(DateTime userInput){
            this.DateAndTimeEntered = userInput;
        }


    }

}
