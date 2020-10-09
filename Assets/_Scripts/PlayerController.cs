//Description: Controls player
//Programmer: Jayson MacFarlane
//Student ID: 100455453
//Date: October 1, 2020
//Verion 1.7

using System.Collections;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Vector3 spawnPoint = new Vector3 (0, 5, 225);

    //Speed sets how fast the player goes, rigidbody allows use of physics
    public float speed = 10;
    Rigidbody rigidbody;

    float jump = 0.0f;

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
        Vector3 movement = new Vector3(hAxis, jump, vAxis) * speed * Time.deltaTime;
        rigidbody.AddRelativeForce(movement, ForceMode.Impulse);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            jump = 20.0f;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Checkpoint"))
        {
            spawnPoint = other.transform.position;
            other.enabled = false;
        }

        if (other.CompareTag("End"))
        {
            Application.LoadLevel(2);
        }

        if (other.CompareTag("DeathPit"))
        {
            this.transform.position = spawnPoint;
        }

        if (other.CompareTag("Mover"))
        {
            this.transform.parent = other.transform;
        }

        if (other.CompareTag("Ceiling"))
        {
            jump = -2.0f;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        this.transform.parent = null;
        jump = 0.0f;
    }
}