using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCollision : MonoBehaviour
{
    private GameManager GM;

    private void Start()
    {
        GM = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.contacts[0].normal == transform.forward || collision.contacts[0].normal == transform.forward * -1 || collision.contacts[0].normal == transform.right || collision.contacts[0].normal == transform.right * -1)
        {
            GM.player.GetComponent<InfiniteMove>().canMove = false;
            GM.GameOver.SetActive(true);
            GM.GameOverIsActive = true;
        }
    }
}