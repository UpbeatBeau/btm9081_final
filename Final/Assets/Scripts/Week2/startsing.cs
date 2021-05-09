using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using UnityEngine;

public class startsing : MonoBehaviour
{
   public static GameObject instance;
   public bool mattishere = false;
   public bool second = true;

   private void Awake()
   {
      if (instance == null)
      {
         instance = this.gameObject;
         DontDestroyOnLoad(gameObject);
      }
      else
      {
         Destroy(gameObject);
      }

      mattishere = true;
   }
}
