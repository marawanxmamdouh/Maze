using UnityEngine;
using UnityEngine.UI;


public class DisplayScore : MonoBehaviour
{
    public Text scoreText;

    void Update()
    {
        scoreText.text = PlayerController.score.ToString(); //+ " Points"
    }
}