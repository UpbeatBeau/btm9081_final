using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonGithub : MonoBehaviour
{
   //Variables
   public Text text;
   public GameObject push;
   public GameObject bye;
   private Camera maincam;
   public GameObject canvas;
   

   private void Start()
   {
      //turn off the text
      text.enabled = false;
      //move the camera and singletonMatt
      Camera.main.transform.position = (canvas.transform.position - new Vector3(0,0,821));
      if (startsing.instance.activeSelf == true)
      {
         startsing.instance.transform.localScale = new Vector3(5f, 5f, 5f);
         startsing.instance.transform.position = canvas.transform.position - new Vector3(300f,385f,0f);
      }
   }

   //used on the button
   public void Github()
   {
      text.enabled = true;
      text.text = "ERROR!!! YOU CAN NOT PUSH WITH MERGE CONFLICTS! PLEASE CONTACT MATT PARKER!";
      push.SetActive(false);
      bye.SetActive(true);

   }
}
