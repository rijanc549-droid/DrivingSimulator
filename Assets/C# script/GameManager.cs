using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject instructionPanel;

    void Start()
    {
        Time.timeScale = 0f;
    }

    public void StartGame()
    {
        instructionPanel.SetActive(false);
        Time.timeScale = 1f;
    }
}
