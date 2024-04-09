using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorOnCollision : MonoBehaviour
{
    private void Start()
    {
        this.GetComponent<MeshRenderer>().material.color = Color.red;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            this.GetComponent<MeshRenderer>().material.color = Color.green;
        } 
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            this.GetComponent<MeshRenderer>().material.color = Color.red;
        }
    }
}
