using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDetector : MonoBehaviour
{
    public Text scoreDetector;
    public int score;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Obstacle"))
        {
            score++;
            
        }
    }
    private void Update()
    {
        scoreDetector.text = score.ToString();
    }
}
