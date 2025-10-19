using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuManager : MonoBehaviour
{
    public GameObject pausePanel;
    public GameObject settingsPanel;
    public GameObject statsPanel;

    private bool isPaused = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!isPaused)
                OpenPause();
            else
                ClosePause();
        }
    }

    public void OpenPause()
    {
        pausePanel.SetActive(true);
        settingsPanel.SetActive(false);
        statsPanel.SetActive(false);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void ClosePause()
    {
        pausePanel.SetActive(false);
        settingsPanel.SetActive(false);
        statsPanel.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void ContinueGame()
    {
        ClosePause();
    }

    public void OpenSettings()
    {
        settingsPanel.SetActive(true);
        pausePanel.SetActive(false);
        statsPanel.SetActive(false);
    }

    public void OpenStats()
    {
        bool isActive = statsPanel.activeSelf;
        statsPanel.SetActive(!isActive);
        if (isActive)
        {
            pausePanel.SetActive(false);
        }
        else
        {
            pausePanel.SetActive(false);
            settingsPanel.SetActive(false);
        }
    }

    public void BackToPause()
    {
        pausePanel.SetActive(true);
        settingsPanel.SetActive(false);
        statsPanel.SetActive(false);
    }

    public void GoToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Lobby");
    }
}