using UnityEngine;
using UnityEngine.TextCore.Text;

public class PanelManger : MonoBehaviour
{

    public GameObject[] characterPanels;

    public void ShowCharacterPanel(int index)
    {
        foreach (GameObject panel in characterPanels)
        {
            panel.SetActive(false);
        }
        if (index >= 0 && index < characterPanels.Length)
        {
            characterPanels[index].SetActive(true);
        }
    }
}
