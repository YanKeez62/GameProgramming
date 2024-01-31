using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class MovePlayer : MonoBehaviour
{
    private CharacterController characterController;
    public TextMeshProUGUI textContainer;
    public TextMeshProUGUI textContainer2;
    private float speed = 100f;
    private int score = 0;
    private float timer = 0f;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }
    void Update()
    {
        Vector3 characterMove = new Vector3(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0, 0);
        characterController.Move(characterMove);
        textContainer.text = "Score : " + score;
        timer += Time.deltaTime;
        textContainer2.text = "Time : " + Mathf.Round(timer * 100f) / 100f;

        if(Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            speed = 300f;
        } else
        {
            speed = 100f;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Collectible")
        {
            other.gameObject.SetActive(false);
            score++;
        }
    }
}
