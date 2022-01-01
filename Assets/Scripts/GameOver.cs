using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject player;
    public Vector3 playerPosition;

    public GameOverScreen gameOverScreen;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
    }
    // Update is called once per frame
    void Update()
    {
        playerPosition = player.transform.position;
        if (PlayerController.lives == 0)
        {
            gameOverScreen.Setup(PlayerController.score);
            //SceneManager.LoadScene("GameOver");
        }
        if (playerPosition.y < 0)
        {
            //TODO Delay
            player.transform.position = Vector3.Lerp(player.transform.position,new Vector3 (0.25f, 1f, 13f),1);
            PlayerController.lives--;
            Debug.Log(PlayerController.lives);
        }
    }
}