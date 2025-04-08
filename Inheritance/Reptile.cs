using System;

namespace Inheritance;

public class Reptile : Animal
{
    public Reptile()
    {
        isAlive = true;
        LegCount = 4;
        LandSeaAir = "Land";
        Age = 0;
    }
    
    public bool isColdBlooded {get; set;}
    public bool isScaly {get; set;}
    public string habitat {get; set;}
    public bool canGrowTail {get; set;}
}