using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mammal : Organism
{
   //variables
    public string reproduces;

   //make the mammal subclass of Organism
    public Mammal(string carbon, string reproduces) :
       base(carbon)
   {
       this.reproduces = reproduces;
       this.type = "Mammal";
   }

   //override to show the new things
    public override string showRecord()
   {
       return base.showRecord() + "Reproduces: " + reproduces + "\n";
   }
}
