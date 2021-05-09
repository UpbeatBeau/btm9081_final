using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Grid4cools : MonoBehaviour
{
    public int width;
    public int height;

    private int[,] grid;

    public GameObject buttonPrefab;
    public GameObject canvas;

    private List<GameObject> spawnButton = new List<GameObject>();

    private void Awake()
    {
        grid = new int[width, height];

        for (var x = 0; x < width; x++)
        {
            for (var y = 0; y < height; y++)
            {
                grid[x, y] = 0;
            }
        }
        UpdateDisplay();
        
    }

    void UpdateDisplay()
    {
        foreach (var button in spawnButton)
        {
            Destroy(button);
        }
        
        
        for (var x = 0; x < width; x++)
        {
            for (var y = 0; y < height; y++)
            {
                if (grid[x, y] == 0)
                {
                    var butt = Instantiate(buttonPrefab);
                    butt.transform.position = new Vector3(x, y);
                    butt.transform.SetParent(canvas.transform, true);
                    spawnButton.Add(butt);
                    GameObject life = butt.gameObject;
                    butt.GetComponent<Button>().onClick.AddListener(() => GameManager.instance.ButtonPress(life));
                }
            }
        }
    }

    void Buttonbye()
    {
        
    }

}
