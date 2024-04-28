using System;
namespace ConsoleUI
{
	public abstract class Vehicle
	{
        public int Year { get; set; } = 2024;

        public string Make { get; set; } = "Generic Make";

        public string Model { get; set; } = "Generic Model";


        public abstract void DriveAbstract();
        

        public virtual void DriveVirtual()
        {
            Console.WriteLine("Default Virtual Drive");
        }
    }
}

