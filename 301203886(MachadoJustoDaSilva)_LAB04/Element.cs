using System;

namespace _301203886_MachadoJustoDaSilva__LAB04
{ 

public class Element
{
    public int elementID { get; set; }
    public string Name { get; set; }
    public string Color { get; set; }

    public override string ToString()
    {
        return Name + " " + Color;
    }
}
}
