using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton : MonoBehaviour
{
    // Variables
    public GameObject canvas;
    public GameObject cantmattParker;
    
    
    void Start()
    {
        //move the camera to the canvas
        Camera.main.transform.position = (canvas.transform.position - new Vector3(0, 0, 821));
        //move singletonMatt to the lower left if you have already tried to add more matts
        if (startsing.instance.activeSelf == true)
        {
            if (startsing.instance.GetComponent<startsing>().second == false)
            {
                Debug.Log("Move Matt");
                startsing.instance.transform.localScale = new Vector3(5f, 5f, 5f);
                startsing.instance.transform.position = canvas.transform.position - new Vector3(300f, 385f, 0f);
            }
        }
        
    }

    //make a random thing appear that says you can not add another
    public void MakeMattParker()
    {
        startsing.instance.GetComponent<startsing>().second = false;
        var newobj = Instantiate(cantmattParker);
        newobj.transform.position = new Vector3(Random.Range(1595f, 2100f), Random.Range(-189f, 193f), 0f);
        newobj.transform.SetParent(canvas.transform);
    }
}
