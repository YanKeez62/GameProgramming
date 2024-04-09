using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private GameObject gameObjectToInstanciate;

    IEnumerator SpawnerCooldown()
    {
        Debug.Log("test");
        Instantiate(gameObjectToInstanciate, gameObject.transform);
        yield return new WaitForSeconds(2f);
        Debug.Log("Après yield");
        StartCoroutine(SpawnerCooldown());
    }
    public void Start()
    {
        StartCoroutine(SpawnerCooldown());
    }
}
