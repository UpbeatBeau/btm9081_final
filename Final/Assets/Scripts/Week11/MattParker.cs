using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MattParker : Human
{
    //Variables
    public bool leaving;
    public string favorite;
    
    //make the MattParker subclass of Human
    public MattParker(string favorite, bool leaving, string carbon, string reproduces, string walks, string haircolor) : base(carbon, reproduces, walks, haircolor)
    {
        this.leaving = leaving;
        this.favorite = favorite;
        this.type = "Matt Parker";
    }

    //update the new info
    public override string showRecord()
    {
        return base.showRecord() + "Leaving? " + leaving + "\n" + "Favorite: " + favorite +"\n";
    }
}
