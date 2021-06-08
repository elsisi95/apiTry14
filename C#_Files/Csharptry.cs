using System;
using System.Collections.Generic;

namespace Code_Coach_Challenge{

class Temp
{
    public int num = 2;
    public Temp() { num++; }
    ~Temp() { num++; }
}
static void Main(string[] args)
{
    Temp t = new Temp();
    Console.WriteLine(t.num);
}

}