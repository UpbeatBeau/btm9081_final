using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonGithub : MonoBehaviour
{
   public Text text;
   public GameObject push;
   public GameObject bye;
   private Camera maincam;
   public GameObject canvas;
   

   private void Start()
   {
      text.enabled = false;
      Camera.main.transform.position = (canvas.transform.position - new Vector3(0,0,821));
      if (startsing.instance.activeSelf == true)
      {
         startsing.instance.transform.localScale = new Vector3(5f, 5f, 5f);
         startsing.instance.transform.position = canvas.transform.position - new Vector3(300f,385f,0f);
      }
   }

   public void Github()
   {
      text.enabled = true;
      text.text = "ERROR!!! YOU CAN NOT PUSH WITH MERGE CONFLICTS! PLEASE CONTACT MATT PARKER!";
      push.SetActive(false);
      bye.SetActive(true);

   }
}
