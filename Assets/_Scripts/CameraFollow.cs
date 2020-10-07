//Description: Has camera follow player
//Programmer: Jayson MacFarlane
//Student ID: 100455453
//Date: September 28, 2020
//Verion 1.0

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    //target is set in Unity editor
    public Transform target;

    public Vector3 offset;

    // Update is called once per frame
    private void LateUpdate()
    {
        //Sets camera position as target position plus offset
        transform.position = target.position + offset;
    }
}
