using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySelf : MonoBehaviour
{
    private GameManager GM;

    private void Start()
    {
        GM = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    void Update()
    {
        if (GM.player.transform.position.z > transform.position.z + 1)
        {
            this.gameObject.SetActive(false);
        }
    }
}
