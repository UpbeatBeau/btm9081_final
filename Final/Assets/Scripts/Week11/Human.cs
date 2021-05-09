using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human : Mammal
{
    public string walks;
    public string haircolor;

    public Human(string carbon, string reproduces, string walks, string haircolor) : base(carbon, reproduces)
    {
        this.haircolor = haircolor;
        this.walks = walks;
        this.type = "Human";
    }

    public override string showRecord()
    {
        return base.showRecord() + "Walks: " + walks + "\n" + "Haircolor: " + haircolor + "\n";
    }
}
