using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MainMenuScript : MonoBehaviour
{

    public GameObject settingspanel;
    public void playGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void OpenSettigs()
    {
        settingspanel.SetActive(true);
    }

    public void CloseSettings()
    {
        settingspanel.SetActive(false);
    }

    public void ToggleSettings()
    {
        settingspanel.SetActive(!settingspanel.activeSelf);
    }
    
    public void QuitGame()
    {
        Debug.Log("Closed");
        Application.Quit();
    }
}
