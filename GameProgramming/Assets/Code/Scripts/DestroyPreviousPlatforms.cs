using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPreviousPlatforms : MonoBehaviour
{
    private GameManager GM;

    private void Start()
    {
        GM = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    void Update()
    {
        if (transform.position.z + 90 < GM.player.transform.position.z) 
        {
            gameObject.SetActive(false);
        }
    }
}
