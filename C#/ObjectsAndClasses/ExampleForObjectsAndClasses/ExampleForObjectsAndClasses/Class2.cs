using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleForObjectsAndClasses
{
    class Dice
    {
        //Contructor with default value
        public Dice()
        {
            this.Sides = 6;
        }

        //Constructor with one parameter
        public Dice(int sides)
        {
            //Sets the value to property Sides
            this.Sides = sides;
        }
        public int Sides { get; set; }

        public string Type { get; set; }

        public int Roll()
        {
            //Creating object from type Random
            Random rnd = new Random();

            return rnd.Next(1, Sides + 1);
        }
    }
}
