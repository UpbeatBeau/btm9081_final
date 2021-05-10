using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class savesytemmanager : MonoBehaviour
{
    //Variables
    public GameObject canvas;
    public string inputtext;
    
    private const string DIR_RES = "/Resources";
    private const string FILE_TOMATT = DIR_RES + "/ToMatt.txt";
    private string FILE_PATH_TOMATT;
    
    void Start()
    {
        //File path
        FILE_PATH_TOMATT = Application.dataPath + FILE_TOMATT;
        
        //move the camera and singletonMatt!
        Camera.main.transform.position = (canvas.transform.position - new Vector3(0,0,821));
        if (startsing.instance.activeSelf == true)
        {
            startsing.instance.transform.localScale = new Vector3(5f, 5f, 5f);
            startsing.instance.transform.position = canvas.transform.position - new Vector3(300f,385f,0f);
        }  
    }

    public void SaveForMatt(string s)
    {
        inputtext = s;
        string fileContents = File.ReadAllText(FILE_PATH_TOMATT);
        fileContents += inputtext + "\n";
        File.WriteAllText(FILE_PATH_TOMATT, fileContents);
    }

  
}
