using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public Player player;
    public GameObject gameOver;

    private void Start()
    {
        //player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        
    }
    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Player health "+ player.health);
        if(player.health <= 0)
        {
            gameOver.SetActive(true);
           
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
            
        }
        
    }
}
