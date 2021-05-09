using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;


public class MattScript : MonoBehaviour
{

   const float MIN_SPEED = 1f;
   private const float MAX_SPEED = 5f;
   private const float MAX_Y = 200;
   private const float MIN_Y = -450;

   private float speed;

   private void Start()
   {
      Reset();
   }

   public void Reset()
   {
      speed = -Random.Range(MIN_SPEED, MAX_SPEED);

      transform.position = new Vector2(Random.Range(-1002, -600), MAX_Y);
   }

   private void Update()
   {
      transform.position = new Vector2(transform.position.x, transform.position.y + speed);

      if (transform.position.y < MIN_Y)
      {
         MattPool.instance.Push(gameObject);
      }
      
   }
}
