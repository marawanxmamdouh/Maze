using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject player;
    public Vector3 playerPosition;
    public int level = 3;
    
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