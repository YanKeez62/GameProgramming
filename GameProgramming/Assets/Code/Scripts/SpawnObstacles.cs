using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnObstacles : MonoBehaviour
{
    public GameObject[] obstacles;
    public GameObject platform;
    public GameManager GM;
    public GameObject pearl;

    private void Start()
    {
        float randomNumber2 = Random.Range(0, 8);
        int roundedNumber2 = Mathf.RoundToInt(randomNumber2);
        for (int i = 0; i <= 60; i += 15)
        {
        float randomNumber = Random.Range(0, 2);
        int roundedNumber = Mathf.RoundToInt(randomNumber);
        int[] possibleValues = new int[] { -5, 0, 5 };
        int randomIndex = Random.Range(0, possibleValues.Length);
        int result = possibleValues[randomIndex];
        Instantiate(obstacles[roundedNumber], new Vector3(result, obstacles[roundedNumber].transform.position.y, platform.transform.position.z + i), transform.rotation);
        }
        if (roundedNumber2 == 1 )
        {
            Instantiate(pearl, new Vector3(GM.player.transform.position.x, 1.5f, platform.transform.position.z + 55), transform.rotation);
        }
    }
}
