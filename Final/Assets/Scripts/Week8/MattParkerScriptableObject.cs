using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu (fileName = "NewMatt", menuName = "ScriptableObjects/Matt", order = 0)]
public class MattParkerScriptableObject : ScriptableObject
{
   public string MattParkerName = "Name the Matt";
   public string MattParkerDescription = "Describe the Matt";

   public MattParkerScriptableObject nextMatt;
   public bool lastMatt;
   public Sprite mattpic;
}
