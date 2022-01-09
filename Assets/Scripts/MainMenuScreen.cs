using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenuScreen : MonoBehaviour
{
    public GameObject scoreScreen;

    public void StartButton()
    {
        scoreScreen.SetActive(true);
        gameObject.SetActive(false);
    }
    
    public void SettingButton()
    {
        //SceneManager.LoadScene("MinGame");
    }
    
    public void QuitButton()
    {
        Application.Quit();
        Debug.Log("Game Closed");
    }
}