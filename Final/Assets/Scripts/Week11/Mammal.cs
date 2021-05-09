using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mammal : Organism
{
   public string reproduces;

   public Mammal(string carbon, string reproduces) :
       base(carbon)
   {
       this.reproduces = reproduces;
       this.type = "mammal";
   }

   public override string showRecord()
   {
       return base.showRecord() + "Reproduces: " + reproduces + "\n";
   }
}
