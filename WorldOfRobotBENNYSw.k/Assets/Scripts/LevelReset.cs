﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelReset : MonoBehaviour
{
    public GameObject player;
    public void GameOver()
    {
        player.SetActive(false);
        SceneManager.LoadScene(0);
    }
}


