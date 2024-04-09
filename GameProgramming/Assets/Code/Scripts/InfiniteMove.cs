using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfiniteMove : MonoBehaviour
{
    public bool canMove = true;
    public bool isGrounded = false;
    public float speed = 12f;
    private float changeSpeed = 4f;
    private float jumpSpeed = 6f;
    public GameObject pos1;
    public GameObject pos2;
    public GameObject pos3;

    private void Start()
    {
        canMove = true;
    }
    void Update()
    {
        if (canMove)
        {
            MoveForward();
            CheckInput();
        }
    }

    void MoveForward()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }

    void CheckInput()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (transform.position.x == -5)
            {
                canMove = false;
                StartCoroutine(MoveToPosition(pos2.transform.position));
            }
            else if (transform.position.x == 0)
            {
                canMove = false;
                StartCoroutine(MoveToPosition(pos3.transform.position));
            }
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            if (transform.position.x == 5)
            {
                canMove = false;
                StartCoroutine(MoveToPosition(pos2.transform.position));
            }
            else if (transform.position.x == 0)
            {
                canMove = false;
                StartCoroutine(MoveToPosition(pos1.transform.position));
            }
        }
        else if (Input.GetKeyDown(KeyCode.Space)) {
            if (isGrounded)
            {
                this.GetComponent<Rigidbody>().AddForce(Vector3.up * jumpSpeed, ForceMode.Impulse);
            }
        }
    }

    IEnumerator MoveToPosition(Vector3 targetPosition)
    {
        float elapsedTime = 0;
        Vector3 startingPos = transform.position;

        while (elapsedTime < 1f)
        {
            MoveForward();
            transform.position = Vector3.Lerp(startingPos, new Vector3(targetPosition.x,transform.position.y,transform.position.z) , elapsedTime);
            elapsedTime += Time.deltaTime * changeSpeed;
            yield return null;
        }
        MoveForward();
        transform.position = new Vector3(targetPosition.x, transform.position.y, transform.position.z);
        canMove = true;
    }

}