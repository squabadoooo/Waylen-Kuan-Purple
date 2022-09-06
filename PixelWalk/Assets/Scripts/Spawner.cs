using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Vector3 spawnPos;
    [Header("ChallengeObj Game Object")]
    public GameObject challengeObject;
    [Header("Default spawn delay time")]
    public float spawnDelay = 0.6f;
    [Header("Default spawn time")]
    public float spawnTime = 2f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("InstantiateObjects", spawnDelay, spawnTime);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = spawnPos;
    }
    void InstantiateObjects()
    {
        Instantiate(challengeObject, transform.position, transform.rotation);
    }
}

