using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawn : MonoBehaviour
{
    public GameObject pipe;
    void Start()
    {
        float rFloat = Random.Range(8.5f, -1f);
        Vector3 v3 = new Vector3(transform.position.x + 10, rFloat, transform.position.z);
        Instantiate(pipe, v3, transform.rotation);
    }
}
