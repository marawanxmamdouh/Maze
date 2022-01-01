using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace
{
    public class GameOverScreen : MonoBehaviour
    {
        public Text scoreText;

        public void Setup(int score)
        {
            gameObject.SetActive(true);
            scoreText.text = score + " POINTS";
        } 
    }
}