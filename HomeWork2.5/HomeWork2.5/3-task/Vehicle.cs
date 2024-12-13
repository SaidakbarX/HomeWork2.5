using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2._5._3_task;

public  class Vehicle
{
    protected int Speed { get; set; }
    protected double _fuel;
    protected double Fuel
    {
        get { return _fuel; }
        set
        {
            if (50 >= value + _fuel)
            {
                _fuel += value;
            }
        }
    }
}
