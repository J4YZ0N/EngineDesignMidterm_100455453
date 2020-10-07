//Description: Controls player
//Programmer: Jayson MacFarlane
//Student ID: 100455453
//Date: October 1, 2020
//Verion 1.2

using System.Collections;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Speed sets how fast the player goes, rigidbody allows use of physics
    public float speed = 50;
    Rigidbody rigidbody;

    //The door player is currently in front of and wants to test
    private GameObject currentDoor;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //Sets horizontal and vertical axis to use input manager definitions
        float hAxis = Input.GetAxis("Horizontal");
        float vAxis = Input.GetAxis("Vertical");

        //Moves character
        Vector3 movement = new Vector3(hAxis, 0, vAxis) * speed * Time.deltaTime;
        rigidbody.MovePosition(transform.position + movement);
    }
}
