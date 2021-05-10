using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private ShuffleBag<string> bag;
    public static GameManager instance;
    public GameObject maincanvas;
    private Vector3 offset = new Vector3(-1.8f, -1.38f, 5.71f);
    
    private const string FILE_TOMATT = DIR_RES + "/ToMatt.txt";
    private string FILE_PATH_TOMATT;
    
    
    
    private const string DIR_RES = "/Resources";
    private const string FILE_LEVELS = DIR_RES + "/levels.txt";
    private string FILE_PATH_LEVELS;
    public string current;

    public Text tomatt;

    private void Awake()
    {
        if (instance == null)
        {
            DontDestroyOnLoad(gameObject);
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        //Variables
        FILE_PATH_TOMATT = Application.dataPath + FILE_TOMATT;
        
        FILE_PATH_LEVELS = Application.dataPath + FILE_LEVELS;
        string fileContents = File.ReadAllText(FILE_PATH_LEVELS);
        string[] filelevels = fileContents.Split(',');

        //shufflebag
        bag = new ShuffleBag<string>();

        for (int i = 0; i < filelevels.Length; i++)
        {
            bag.Add(filelevels[i]);
        }
        print(bag.Count);
        Camera.main.transform.position = (maincanvas.transform.position - offset);
        //Debug.Log(filelevels[11]);
        
        //string startinghi = "Hi Matt! \n";
        //File.WriteAllText(FILE_PATH_TOMATT, startinghi);
    }

    //make buttons that load a random scene
    public void ButtonPress(GameObject here)
    {
        string result = "";
        result = bag.Next();
        current = result;
        SceneManager.LoadScene(result, LoadSceneMode.Additive);
        Destroy(here);
    }

    //used on byebutton
    public void Return()
    {
        Camera.main.transform.position = (maincanvas.transform.position - offset);
        SceneManager.UnloadScene(current);
        if (startsing.instance.activeSelf == true)
        {
            startsing.instance.transform.localScale = new Vector3(.05f, .05f, .05f);
            startsing.instance.transform.position = maincanvas.transform.position - new Vector3(.5f,1.1f,0f);
        }
    }

    //update the text for Matt
    private void Update()
    {
        tomatt.text = File.ReadAllText(FILE_PATH_TOMATT);
    }
}
