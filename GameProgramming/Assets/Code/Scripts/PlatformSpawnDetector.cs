using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlatformSpawnDetector : MonoBehaviour
{
    public GameObject basePlatform;
    public GameObject platformToInstantiate;
    private float xPosition;
    private float yPosition;
    private float zPosition;
    private void Start()
    {
        xPosition = basePlatform.transform.position.x;
        yPosition = basePlatform.transform.position.y;
        zPosition = basePlatform.transform.position.z;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player") {
            zPosition = platformToInstantiate.transform.position.z + 90;
            Instantiate(platformToInstantiate, new Vector3(xPosition, yPosition, zPosition), basePlatform.transform.rotation);
                }
    }
    void Update()
    {
        
    }
}
