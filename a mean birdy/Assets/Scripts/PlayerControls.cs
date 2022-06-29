﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    //Game manager object
    [Header("Game Controller Object for the game")]
    public GameController gameController;
    [Header("Default Velocity")]
    public float velocity = 1;
    //Phisics for the bird
    private Rigidbody2D rb;
    //height of the bird object on the y axis
    private float objectHeight;
    // Start is called before the first frame update
    void Start()
    {
        //Game Conroller component
        gameController = GetComponent<GameController>();
        //Speed for game is at a playing state
        Time.timeScale = 1;
        rb = GetComponent<Rigidbody2D>();
        //Object Height equals the size of the height of the sprite
        objectHeight = transform.GetComponent<SpriteRenderer>().bounds.size.y / 2;
    }

    // Update is called once per frame
    void Update()
    {
        // If the left mouse button is clicked
        if (Input.GetMouseButtonDown(0))
        {
            //The bird will float up on the Y axis
            //and float back down on Y axis
            rb.velocity = Vector2.up * velocity;
        }
    }
}