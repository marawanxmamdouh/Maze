using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject player;
    public Vector3 playerPosition;
    public static int level = 3;
    public static int score = 0;

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
        if (level == 0)
        {
            gameOverScreen.Setup(score);
            //SceneManager.LoadScene("GameOver");
        }
        if (playerPosition.y < 0)
        {
            //TODO Delay
            player.transform.position = Vector3.Lerp(player.transform.position,new Vector3 (0.25f, 1f, 13f),1);
            level--;
            Debug.Log(level);
        }
    }
}