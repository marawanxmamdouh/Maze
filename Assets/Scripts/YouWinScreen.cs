using UnityEngine;
using UnityEngine.SceneManagement;

public class YouWinScreen : MonoBehaviour
{
    public void Setup()
    {
        gameObject.SetActive(true);
    }

    public void PlayAgainButton()
    {
        SceneManager.LoadScene("MinGame");
        PlayerController.lives = 3;
        PlayerController.score = 0;
        PlayerController.canMove = true;
    }
    
    public void MainMenuButton()
    {
        //TODO add main menu
        SceneManager.LoadScene("GameOver");
    }
}
