using System;
namespace ConsoleUI
{
	public class MotorCycle: Vehicle
	{
        public int NumberOfWheels { get; set; } = 2;

        public override void DriveAbstract()
        {
            Console.WriteLine("The Motor cycke has 2 wheels");
        }
    }
	
    
}

