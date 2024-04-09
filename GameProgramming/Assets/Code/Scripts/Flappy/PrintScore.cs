using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PrintScore : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public BirdCollision bc;
    void Update()
    {
        scoreText.text = "Score : " + bc.score;
    }
}
