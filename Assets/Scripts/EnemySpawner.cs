using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject Enemy;

    void Start()
    {
        StartCoroutine(StartSpawning());
    }

    IEnumerator StartSpawning()
    {
        yield return new WaitForSeconds(Random.Range(7f, 10f));
        Instantiate(Enemy, transform.position, Quaternion.identity);
        StartCoroutine(StartSpawning());
    }
}
