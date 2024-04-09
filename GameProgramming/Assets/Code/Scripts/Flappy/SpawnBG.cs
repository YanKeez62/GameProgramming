using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBG : MonoBehaviour
{
    public GameObject BG;
    void Start()
    {
        Vector3 v3 = new Vector3(transform.position.x + 66, transform.position.y, transform.position.z);
        Instantiate(BG, v3, transform.rotation);
    }
}
