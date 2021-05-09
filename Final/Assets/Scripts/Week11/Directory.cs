using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Directory : MonoBehaviour
{
    public Text text;

    public List<Organism> organismList;

    private int recordNum = 0;

    private void Start()
    {
        organismList = new List<Organism>();
        Organism first = new Organism("carbon based");
        Organism second = new Mammal("carbon based","no eggs");
        Organism third = new Human("carbon based", "no eggs", "walks on two feet", "brown");
        Organism fourth = new MattParker("...........", true, "carbon based", "no eggs", "walks on two feet",
            "brown");
        
        
        
        organismList.Add(first);
        organismList.Add(second);
        organismList.Add(third);
        organismList.Add(fourth);
        
        UpdateRecord();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            UpdateRecord();
        }
    }

    void UpdateRecord()
    {
        Organism thing = organismList[recordNum % organismList.Count];

        text.text = thing.showRecord();

        recordNum++;
    }
}
