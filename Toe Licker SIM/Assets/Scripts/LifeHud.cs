using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeHud : MonoBehaviour
{
    private GameObject[] hearts;
    private int lives = 3;
    public GameObject background;
    void Start()
    {
        hearts = GameObject.FindGameObjectsWithTag("heart"); //BotayBotayBotayBotayBotayBotayBotayBotayBotayBotayBotayBotayBotayBotayBotayBotayBotayBotayBotayBotayBotayBotayBotayBotayBotayBotayBotayBotayBotayBotayBotayBotayBotayBotayBotayBotayBotayBotayBotayBotayBotayBotayBotayBotayBotayBotayBotayBotayBotayBotayBotayBotayBotayBotayBotayBotayBotayBotayBotayBotayBotay
    }

    
    void Update()
    {
        
    }

    public void HurtPlayer()
    {
        Debug.Log("JOJO SIWA!");
        lives -= 1;
        hearts[lives].SetActive(false);
        if (lives == 0)
        {
            background.GetComponent<GameManager>().GameOver();
        }
    }

    public void HealPlayer()
    {
        Debug.Log("NOOOOOOOOOOOOOOOOOO!");
            if (lives < 3)
        {
            hearts[lives].SetActive(true!);
            lives += 1;
        }
    }
}
