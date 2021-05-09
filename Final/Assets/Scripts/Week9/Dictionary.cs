using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dictionary : MonoBehaviour
{
    public Text display;
    public GameObject byebutton;
    public GameObject canvas;

    private void Start()
    {
        Camera.main.transform.position = (canvas.transform.position - new Vector3(0,0,621));
        if (startsing.instance.activeSelf == true)
        {
            startsing.instance.transform.localScale = new Vector3(5f, 5f, 5f);
            startsing.instance.transform.position = canvas.transform.position - new Vector3(250f,340f,0f);
        }
    }

    public void Update()
    {
        DisplayResources();
       if (resourcesOwned.ContainsKey("COOL."))
        {
            byebutton.SetActive(true);
        }
    }

    private Dictionary<string, int> resourcesOwned = new Dictionary<string, int>();
    
    public void AddResource(string resourceType, int amountToAdd)
    {
        if (resourcesOwned.ContainsKey(resourceType))
        {
            resourcesOwned[resourceType] = resourcesOwned[resourceType] + amountToAdd;
            Debug.Log("You own" + resourcesOwned[resourceType] + " of " + resourceType);
        }
        else
        {
            resourcesOwned.Add(resourceType, amountToAdd);
        }
    }

    public bool RemoveResource(string resourceType, int cost)
    {
        if (!HasEnoughResources(resourceType, cost))
        {
            return false;
        }

        resourcesOwned[resourceType] = resourcesOwned[resourceType] - cost;
        
        if (resourcesOwned[resourceType] == 0)
            resourcesOwned.Remove(resourceType);

        return true;
    }

    public bool HasEnoughResources(string resourceType, int amount)
    {
        if (!resourcesOwned.ContainsKey(resourceType) || resourcesOwned[resourceType] < amount)
        {
            return false;
        }

        return true;
    }

    public void AddResources(string resourceString)
    {
        AddResource(resourceString, 10);
    }

    public void DisplayResources()
    {
        display.text = "Owned Resources: \n";

        foreach (KeyValuePair<string, int> keyValuePair in resourcesOwned)
        {
            display.text += "\n" + keyValuePair.Key + " (" + resourcesOwned[keyValuePair.Key] + ")";
        }
    }

    public void BuyItem(string item)
    {
        var successfulPurchase = false;

        switch (item.ToUpper())
        {
            case "SEMICOLON":
                successfulPurchase = RemoveResource("CODE", 20);
                break;
            case "COROUTINE":
                successfulPurchase = RemoveResource("SEMICOLON", 3);
                break;
            case "BASKETBALL":
                successfulPurchase = RemoveResource("COROUTINE", 2);
                break;
            case "COOL.":
                successfulPurchase = RemoveResource("BASKETBALL", 1);
                break;
        }

        if (successfulPurchase)
        {
            if (resourcesOwned.ContainsKey(item.ToUpper()))
            {
                resourcesOwned[item.ToUpper()] = resourcesOwned[item.ToUpper()] + 1;
            }
            else
            {
                resourcesOwned.Add(item.ToUpper(), 1);
            }
        }
    }
}
