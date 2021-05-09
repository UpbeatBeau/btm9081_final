using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MattParker : Human
{
    public bool leaving;
    public string favorite;
    
    public MattParker(string favorite, bool leaving, string carbon, string reproduces, string walks, string haircolor) : base(carbon, reproduces, walks, haircolor)
    {
        this.leaving = leaving;
        this.favorite = favorite;
        this.type = "Matt Parker";
    }

    public override string showRecord()
    {
        return base.showRecord() + "Leaving? " + leaving + "\n" + "Favorite: " + favorite +"\n";
    }
}
