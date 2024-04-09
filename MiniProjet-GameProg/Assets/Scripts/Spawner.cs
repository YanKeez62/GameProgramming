using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private GameObject gameObjectToInstanciate;
    private float xMin = -920f;
    private float xMax = -624f;

    IEnumerator SpawnerCooldown()
    {
        float randomX = Random.Range(xMin, xMax);
        Instantiate(gameObjectToInstanciate, new Vector3(randomX, 125.9f, 27.05f), Quaternion.identity);
        yield return new WaitForSeconds(2f);
        StartCoroutine(SpawnerCooldown());
    }

    public void Start()
    {
        StartCoroutine(SpawnerCooldown());
    }
}
