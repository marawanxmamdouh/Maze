using UnityEngine;
using UnityEngine.SceneManagement;

public class YouWinScreen : MonoBehaviour
{
    
    public GameObject mainMenuScreen;
    public void Setup()
    {
        gameObject.SetActive(true);
    }

    public void PlayAgainButton()
    {
        SceneManager.LoadScene("MinGame");
        mainMenuScreen.SetActive(false);
        PlayerController.lives = 3;
        PlayerController.score = 0;
        PlayerController.canMove = true;
    }
    
    public void MainMenuButton()
    {
        PlayAgainButton();
        gameObject.SetActive(false);
        mainMenuScreen.SetActive(true);
    }
}
