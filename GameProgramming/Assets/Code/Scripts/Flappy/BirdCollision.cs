using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class BirdCollision : MonoBehaviour
{
    public bool isDead;
    private GameManagerFlappy GM;
    public int score = 0;
    private void Start()
    {
        GM = GameObject.Find("GameManager").GetComponent<GameManagerFlappy>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Tuyau" || collision.gameObject.tag == "Limit")
        {
            isDead = true;
            GetComponentInChildren<Moves>().speed = 0;
            GetComponentInChildren<Moves>().jumpSpeed = 0;
            GetComponentInChildren<Rigidbody>().isKinematic = true;
            GameObject.Find("AudioDeath").GetComponentInChildren<AudioSource>().Play();
            GM.gameOverPanel.SetActive(true);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Coin")
        {
            score += 1;
            other.gameObject.SetActive(false);
            gameObject.GetComponentInChildren<AudioSource>().Play();
        }
    }
}
