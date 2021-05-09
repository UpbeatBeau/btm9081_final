using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoreDataManager : MonoBehaviour
{
    public GameObject canvas;

    public float gameTime = 10;
    public Text displaytext;
    private float timer = 0;
    private bool waiting = true;
    public GameObject byebutton;
    private void Start()
    {
        Camera.main.transform.position = (canvas.transform.position - new Vector3(0,0,621));
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
        timer += Time.deltaTime;

        if (!waiting)
        {
            displaytext.text = "Now back to class!";
            byebutton.SetActive(true);
        }
        else
        {
            displaytext.text =
                "\n This week we covered more complex data and timers. Take 10 seconds to appreciate Matt Parker instead!" +
                "\n\nTime: " + (int) (gameTime - timer + 1);

        }

        if (gameTime < timer && waiting)
        {
            waiting = false;
        }
    }
}
