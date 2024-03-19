using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangColorByTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if ( other.name == "Sphere")
        {
            GetComponent<Renderer>().material.color = Color.yellow;

            other.GetComponent<Renderer>().material.color = Color.black;
        }
    }//OnTriggerEnter


}//ChangColorByTrigger
