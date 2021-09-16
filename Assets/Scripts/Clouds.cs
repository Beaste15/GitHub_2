using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clouds : MonoBehaviour
{
   public float speed = 1.5f;
    
    // Update is called once per frame
    void Update()
    {
        //we store the current postion value of the transform of the object this compnent is in
        //Basically we store the current position of the object
        Vector3 temp = this.transform.position;

        //We add speed to the current X value of temp
        temp.x = temp.x + speed * Time.deltaTime;

        //Alternative way of writing 
        //Temp.x += speed;

        //We assign temp as the new position of the object
        //We're teleportingthe object in very small amounts really quickly
        this.transform.position = temp;
    }
}
