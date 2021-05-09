using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalScript : MonoBehaviour
{
    public GameObject byebutton;
    private GameObject canvas;

    private void Start()
    {
        canvas = GameObject.Find("CanvasASCII");
    }


    void OnTriggerEnter2D(Collider2D other) //if something enters the trigger
    {
        //Increase the Score Property in the ASCIILevelLoader
        //that we reference through the GameManager Singleton
       var newobj = Instantiate(byebutton);
       newobj.transform.SetParent(canvas.transform);
       newobj.transform.position = new Vector3(-400,530,-3); 
    }
}
