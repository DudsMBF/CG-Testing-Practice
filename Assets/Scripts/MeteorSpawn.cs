using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Meteor : MonoBehaviour
{
    public Transform[] meteorsSpawn;
    public GameObject meteorPrefab;

    [Header("Spawn Settings")]
    [SerializeField] private float spawnDelay;

    private float timeSinceLast;

    void Start()
    {
        timeSinceLast = spawnDelay;
    }
    void Update()
    {
        timeSinceLast -= 1f;

        if (timeSinceLast == 0)
        {
            SpawnMeteor();
            timeSinceLast = spawnDelay;
        }
    }

    void SpawnMeteor()
    {
        int random = Random.Range(0 , meteorsSpawn.Length);
        Transform selected = meteorsSpawn[random].transform;

        Instantiate(meteorPrefab, selected.position, Quaternion.identity);
    }
}
