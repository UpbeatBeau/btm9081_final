using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JsonManager : MonoBehaviour
{
    public GameObject canvas;
    // Start is called before the first frame update
    void Start()
    {
        Camera.main.transform.position = (canvas.transform.position - new Vector3(0,0,621));
        if (startsing.instance.activeSelf == true)
        {
            startsing.instance.transform.localScale = new Vector3(5f, 5f, 5f);
            startsing.instance.transform.position = canvas.transform.position - new Vector3(250f,340f,0f);
        }
    }

   
}
