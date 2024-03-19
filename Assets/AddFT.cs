using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddFT : MonoBehaviour
{
    public float force = 200;
    public float torque = 50;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }// Start 

     
    void Update()
    {
        if (Input.GetKeyDown( KeyCode.Space) )
        {
            rb.AddForce(force, 0, 0);
            rb.AddTorque(0, torque, 0);

        }
    }// Update

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Pin")
        {
            collision.gameObject.GetComponent<Rigidbody>().AddForce(force, force, force);
        }
    }//OnCollisionEnter

}//AddFT
