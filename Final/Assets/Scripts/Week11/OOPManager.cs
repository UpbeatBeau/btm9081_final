using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OOPManager : MonoBehaviour
{
    //varibales
    public GameObject canvas;
    
    void Start()
    {
        //moves the camera to the canvas position to see the scene
        Camera.main.transform.position = (canvas.transform.position - new Vector3(0,0,621));
        //puts singletonMatt into the lower left corner
        if (startsing.instance.activeSelf == true)
        {
            startsing.instance.transform.localScale = new Vector3(5f, 5f, 5f);
            startsing.instance.transform.position = canvas.transform.position - new Vector3(250f,340f,0f);
        }
    }
}
