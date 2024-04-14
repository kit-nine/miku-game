using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    //allows us to target a specific game object to track its transform values
    public Transform target;

    //creating a new vector3 to offset the camer from the player position. the last value is z space where we can contril the depth of the camera
    public Vector3 offset = new Vector3(0, 2, -10); 


    public float smoothTime = 0.25f;

    Vector3 currentVelocity;
    // Update is called once per frame
    void LateUpdate()
    {
        //here we are transforming the position of the camera using smoothdamp method. it needs the current position of the object, where it needs to go, its current velocity, and how long it should take to get to
        transform.position = Vector3.SmoothDamp(transform.position, target.position + offset, ref currentVelocity, smoothTime);       
    }
}
