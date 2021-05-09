using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptobjManager : MonoBehaviour
{
  public MattParkerScriptableObject currentMatt;
  
  public Text mattName;
  public Text mattDesc;
  public Image mattImg;

  public GameObject buttonnext;
  public GameObject canvas;
  public GameObject byebutton;

  private void Start()
  {
    Camera.main.transform.position = (canvas.transform.position - new Vector3(0,0,621));
    if (startsing.instance.activeSelf == true)
    {
      startsing.instance.transform.localScale = new Vector3(5f, 5f, 5f);
      startsing.instance.transform.position = canvas.transform.position - new Vector3(250f,340f,0f);
    }
    UpdateMatt();
  }

  public void NextMatt()
  {
    currentMatt = currentMatt.nextMatt;
    UpdateMatt();
  }
  public void UpdateMatt()
  {
    mattName.text = currentMatt.MattParkerName;
    mattDesc.text = currentMatt.MattParkerDescription;
    mattImg.sprite = currentMatt.mattpic;
    if (currentMatt.lastMatt == true)
    {
      buttonnext.SetActive(false);
      byebutton.SetActive(true);
    }
  }
}
