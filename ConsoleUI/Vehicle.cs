using System;
using System.Runtime.InteropServices.JavaScript;

namespace ConsoleUI;

public abstract class Vehicle
{
    public int  Year { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }

    public abstract void DriveAbstract();

    public virtual void DriveVirtual()
    {
        Console.WriteLine("Vehicle Drives");
    }
    
        
}