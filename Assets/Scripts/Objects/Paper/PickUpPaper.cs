using UnityEngine;

public class PickUpPaper : MonoBehaviour
{
    public GameObject paperUI;

    private bool isPaperOpen = false;

    public void TogglePaper()
    {
        isPaperOpen = !isPaperOpen;
        paperUI.SetActive(isPaperOpen);
        if (isPaperOpen)
        {
            Time.timeScale = 0f; // Pause the game
        }
        else
        {
            Time.timeScale = 1f; // Resume the game
        }
    }
}
