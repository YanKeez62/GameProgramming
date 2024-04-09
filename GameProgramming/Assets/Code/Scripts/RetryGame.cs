using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryGame : MonoBehaviour
{
    public Objectives objectives;
    private GameManager GM;
    private void Start()
    {
        GM = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    public void RestartTheGame()
    {
        SceneManager.LoadScene("Runner");
        objectives.totalScore= 0;
        objectives.coins= 0;
        objectives.pearls = 0;
        GM.GameOver.SetActive(false); 
        GM.GamePanel.SetActive(true);
    }
}
