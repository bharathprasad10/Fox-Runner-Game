﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public int damage = 1;
    public float speed;
    public GameObject obstacleEffect;
    private Shake shake;

    private void Start()
    { 
            shake = GameObject.FindGameObjectWithTag("CameraShake").GetComponent<Shake>();
       
       
        
    }

    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Instantiate(obstacleEffect, transform.position, Quaternion.identity);
            other.GetComponent<Player>().health -= damage;

            

            //Player Damage
            //Debug.Log(other.GetComponent<Player>().health);
            Destroy(gameObject);
            shake.CamShake();
        }
    }
}
