﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelReset : MonoBehaviour
{
    public ParticleSystem explosion;
    
    public GameObject player;

    private void Start()
    {
        explosion.Stop();
    }
    public void GameOver()
    {
        player.SetActive(false);
        Invoke("Reload", 2);
        explosion.Play();
    }

    void Reload()
    {
        SceneManager.LoadScene(1);
    }



    private void FixedUpdate()
    {
        explosion.transform.position = player.transform.position;
    }
}


