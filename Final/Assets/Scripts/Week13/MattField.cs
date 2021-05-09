using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class MattField : MonoBehaviour
{
    public float intervalMin = 0.1f;
    public float intervalMax = 0.5f;
    public float numMatts = 15;

    private void Start()
    {
        Invoke("SpawnMatt", intervalMin);
    }

    void SpawnMatt()
    {
        for (int i = 0; i < numMatts; i++)
        {
            GameObject matt = MattPool.instance.GetMatt();
        }
        
        Invoke("SpawnMatt", Random.Range(intervalMin,intervalMax));
    }
}
