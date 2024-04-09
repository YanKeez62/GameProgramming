using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moves : MonoBehaviour
{
    public float speed = 6f;
    public float jumpSpeed = 10f;
    public GameObject sw;
    private BirdCollision bc;
    private void Start()
    {
        bc = GetComponent<BirdCollision>();
    }
    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * speed);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            this.GetComponent<Rigidbody>().AddForce(Vector3.up * jumpSpeed, ForceMode.Impulse);
            if(!bc.isDead)
            {
                sw.GetComponentInChildren<AudioSource>().Play();
            }
        }
    }
}
