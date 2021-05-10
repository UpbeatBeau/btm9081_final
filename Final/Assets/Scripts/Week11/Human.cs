using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human : Mammal
{
    //Variables
    public string walks;
    public string haircolor;

    //make the Human subclass of mammal
    public Human(string carbon, string reproduces, string walks, string haircolor) : base(carbon, reproduces)
    {
        this.haircolor = haircolor;
        this.walks = walks;
        this.type = "Human";
    }

    //update the new info
    public override string showRecord()
    {
        return base.showRecord() + "Walks: " + walks + "\n" + "Haircolor: " + haircolor + "\n";
    }
}
