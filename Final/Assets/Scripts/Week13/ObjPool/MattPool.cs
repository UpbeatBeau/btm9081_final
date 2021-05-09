using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MattPool : ObjectPool
{
    public GameObject matt;

    public static MattPool instance;

    private void Start()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    protected override GameObject GetNewObject()
    {
        return Instantiate<GameObject>(matt);
    }

    public GameObject GetMatt()
    {
        GameObject recycledMatt = Get();

        recycledMatt.GetComponent<MattScript>().Reset();

        return recycledMatt;
    }
    
}
