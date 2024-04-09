using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Profiling;
using UnityEngine;

public class Objectives : MonoBehaviour
{
    public int totalScore = 0;
    public int pearls = 0;
    public int coins = 0;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI jewelsText;
    public TextMeshProUGUI coinsText;
    public AudioSource coinCollectSound;
    public AudioSource pearlCollectSound;
    private GameManager GM;
    private void Start()
    {
        GM = GameObject.Find("GameManager").GetComponent<GameManager>();
        StartCoroutine(AddPointEachSecond());
    }
    private void Update()
    {
        scoreText.text = "Total score : " + totalScore;
        jewelsText.text = "Pearls : " + pearls;
        coinsText.text = "Coins : " + coins;
        if ( GM.GameOverIsActive == true) {
            GM.GamePanel.SetActive(false);
            StopAllCoroutines();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {
            totalScore += 1;
            coins += 1;
            coinCollectSound.Play();
            other.gameObject.SetActive(false);
        }
        if (other.gameObject.tag == "Jewel")
        {
            totalScore += 100;
            pearls += 1;
            pearlCollectSound.Play();
            other.gameObject.SetActive(false);
        }
    }
    private IEnumerator AddPointEachSecond()
    {
        yield return new WaitForSeconds(1);
        totalScore += 1;
        StartCoroutine(AddPointEachSecond());
    }
}
