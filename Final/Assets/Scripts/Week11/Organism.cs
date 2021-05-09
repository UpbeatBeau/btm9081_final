using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Organism
{
    public string carbon;
    public string type;

    public Organism(string carbon)
    {
        this.carbon = carbon;
        type = "Organism";
    }

    public virtual string showRecord()
    {
        return
            "Type: " + type + "\n" + "Carbon: " + carbon + "\n";

    }
    
}
