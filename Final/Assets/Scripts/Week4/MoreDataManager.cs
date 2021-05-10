using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoreDataManager : MonoBehaviour
{
    //variables
    public GameObject canvas;

    public float gameTime = 10;
    public Text displaytext;
    private float timer = 0;
    private bool waiting = true;
    public GameObject byebutton;
    private void Start()
    {
        //move the camera to the canvas
        Camera.main.transform.position = (canvas.transform.position - new Vector3(0,0,621));
        
        //move SingletonMatt to lower left hand corner
        if (startsing.instance.activeSelf == true)
        {
            startsing.instance.transform.localScale = new Vector3(5f, 5f, 5f);
            startsing.instance.transform.position = canvas.transform.position - new Vector3(250f,340f,0f);
        }
        
        byebutton.SetActive(false);

        timer = 0;
    }

    private void Update()
    {
        //make a timer
        timer += Time.deltaTime;

        //if you are done waiting activate the button and display this
        if (!waiting)
        {
            displaytext.text = "Now back to class!";
            byebutton.SetActive(true);
        }
        //while waiting display this and the timer
        else
        {
            displaytext.text =
                "\n This week we covered more complex data and timers. Take 10 seconds to appreciate Matt Parker instead!" +
                "\n\nTime: " + (int) (gameTime - timer + 1);

        }

        //make it so the game lasts as long as the timer
        if (gameTime < timer && waiting)
        {
            waiting = false;
        }
    }
}
