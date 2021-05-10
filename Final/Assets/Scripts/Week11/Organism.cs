using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Organism
{
    //variables
    public string carbon;
    public string type;

    //make an Organism class
    public Organism(string carbon)
    {
        //add a carbon and type to it
        this.carbon = carbon;
        type = "Organism";
    }

    //show the record of the class
    public virtual string showRecord()
    {
        return
            "Type: " + type + "\n" + "Carbon: " + carbon + "\n";

    }
    
}
