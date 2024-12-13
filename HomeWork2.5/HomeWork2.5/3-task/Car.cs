using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2._5._3_task;

public class Car:Vehicle
{
    public void Refuel(int amount)
    {
        Fuel += amount;
    }
    public void Drive (int distance)
    {
        Console.WriteLine(distance/Speed);
    }
}
