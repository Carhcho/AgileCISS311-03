using System;
using System.Collections.Generic;
using System.Text;

namespace dropbox03
{
    class Vehicle
    {
        //auto properties
        public int XPosition { get; set; }
        public int YPosition { get; set; }
        public char VehicleSymbol { get; set; }
        public ConsoleColor VehicleColor { get; set; }
        public int Speed { get; set; }
        //constructor
        public Vehicle(int xPosition, int yPosition, char vehicleSymbol, ConsoleColor vehicleColor, int speed)
        {
            XPosition = xPosition;
            YPosition = yPosition;
            VehicleSymbol = vehicleSymbol;
            VehicleColor = vehicleColor;
            Speed = speed;
        }
        //methods
        public void MoveLeft()
        {
            XPosition--;
        }
        public void MoveRight()
        {
            XPosition ++;
        }
        public void Accelerate()
        {
            Speed += 10;
        }
        public void Brake()
        {
            Speed -= 10;
        }
    }
}
