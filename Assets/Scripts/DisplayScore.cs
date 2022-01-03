using UnityEngine;
using UnityEngine.UI;


public class DisplayScore : MonoBehaviour
{
    public Text scoreText;
    public RawImage heart1;
    public RawImage heart2;
    public RawImage heart3;
    
    void Update()
    {
        scoreText.text = PlayerController.score.ToString(); //+ " Points"
        switch (PlayerController.lives)
        {
            case 2:
                heart3.gameObject.SetActive(false);
                break;
            case 1:
                heart2.gameObject.SetActive(false);
                break;
            case 0:
                heart1.gameObject.SetActive(false);
                break;
        }
    }
}