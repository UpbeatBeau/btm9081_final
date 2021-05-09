using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject canvas;
    public GameObject cantmattParker;
    
    
    void Start()
    {
        
        Camera.main.transform.position = (canvas.transform.position - new Vector3(0, 0, 821));
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

    public void MakeMattParker()
    {
        startsing.instance.GetComponent<startsing>().second = false;
        var newobj = Instantiate(cantmattParker);
        newobj.transform.position = new Vector3(Random.Range(1595f, 2100f), Random.Range(-189f, 193f), 0f);
        newobj.transform.SetParent(canvas.transform);
    }
}
