using UnityEngine;

public class ClickSound : MonoBehaviour
{
    public AudioClip clickSound; 
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (AudioManager.instance != null && clickSound != null)
            {
                AudioManager.instance.PlaySFX(clickSound);
            }
        }
    }
}