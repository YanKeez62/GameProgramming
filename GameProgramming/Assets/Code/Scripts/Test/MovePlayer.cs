using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    private CharacterController characterController;
    public float speed = 5f;
    public void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    public void Update()
    {
        Vector3 characterMove = new Vector3(Input.GetAxis("Vertical") * speed * Time.deltaTime, 0, -Input.GetAxis("Horizontal") * speed * Time.deltaTime);
        characterController.Move(characterMove);
    }
}
