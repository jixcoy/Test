using System;

namespace CSharpPractice
{
    internal class CarTestClass
    {
        /*  This class will provide the following information:
            - how many doors are in the car
            - how many wheels the car has
            - how many passengers can the car hold (including the driver)
            - what color the car is
         */
        private int doors;
        private int passengers;
        private int wheels;

        public CarTestClass(int doors, int passengers, int wheels, string color)
        {
            this.Doors = doors;
            this.Passengers = passengers;
            this.Wheels = wheels;
            this.Color = color;
        }
        public int Doors
        {
            get { return doors; }
            set
            {
                if ((value > 4)) { doors = 4; }
                else { doors = value; }
            }
        }
        public int Passengers { get; set; }
        public int Wheels
        {
            get { return wheels; }
            set
            {
                if (value % 2 != 0) { wheels = 4; }
                else { wheels = value; }
            }   
        }
        public string Color { get; set; }
    }
}
