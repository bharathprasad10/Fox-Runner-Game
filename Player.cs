using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    Vector2 targetPos;
    public float yIncrement;
    public float speed;
    public float maxHeight;
    public float minHeight;
    public int health = 3;

    public GameObject playerEffect;
    public Animator animator;
    public Text healthMeter;
    public string healthText = "HP: ";

    // Update is called once per frame
    void Update()
    {
        if(health <= 0)
        {
            Destroy(gameObject);
        }
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.W) && transform.position.y < maxHeight)
        {
            targetPos = new Vector2(transform.position.x, transform.position.y + yIncrement);
            Instantiate(playerEffect, transform.position, Quaternion.identity);
            animator.SetTrigger("Shake");
            //transform.position = targetPos;
        }
        else if (Input.GetKeyDown(KeyCode.S) && transform.position.y > minHeight)
        {
            targetPos = new Vector2(transform.position.x, transform.position.y - yIncrement);
            Instantiate(playerEffect, transform.position, Quaternion.identity);
            animator.SetTrigger("Shake");

            //transform.position = targetPos;

        }

        healthMeter.text = healthText + health.ToString();

    }
}
