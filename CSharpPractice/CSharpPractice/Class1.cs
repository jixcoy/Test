using System;


namespace CSharpPractice
{
    internal class CarTestClass
    {
        private int doors;

        public int Doors
        {
            get { return doors; }
            set
            {
                if ((value > 4)) { doors = 4; }
                else { doors = value; }
            }
        }
        public int Wheels { get; set; }

    }
}
