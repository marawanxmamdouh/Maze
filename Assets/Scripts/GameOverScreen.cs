using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
    {
        public Text scoreText;

        public void Setup(int score)
        {
            gameObject.SetActive(true);
            scoreText.text = score + " POINTS";
        }

        public void RestartButton()
        {
            SceneManager.LoadScene("MinGame");
            GameOver.level = 3;
            GameOver.score = 0;
        }
        public void MainMenuButton()
        {
            //TODO add main menu
            SceneManager.LoadScene("GameOver");
        }
    }