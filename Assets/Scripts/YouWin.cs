using UnityEngine;

public class YouWin : MonoBehaviour
{
    public YouWinScreen youWinScreen;
    public GameObject player;

    void Update()
    {
        if (PlayerController.score == 50)
        {
            PlayerController.canMove = false;
            youWinScreen.Setup();
        }
    }
}