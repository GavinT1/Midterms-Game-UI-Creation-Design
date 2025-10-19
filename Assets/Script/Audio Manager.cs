using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    public AudioMixer audioMixer;
    public AudioSource bgmSource;
    public AudioSource sfxSource;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        LoadVolumes();
    }

    public void PlaySFX(AudioClip clip)
    {
        sfxSource.PlayOneShot(clip);
    }

    public void SetMasterVolume(float value)
    {
        audioMixer.SetFloat("MasterVol", Mathf.Log10(Mathf.Clamp(value, 0.0001f, 1)) * 20);
        PlayerPrefs.SetFloat("MasterVol", value);
    }

    public void SetBGMVolume(float value)
    {
        audioMixer.SetFloat("BGMVol", Mathf.Log10(Mathf.Clamp(value, 0.0001f, 1)) * 20);
        PlayerPrefs.SetFloat("BGMVol", value);
    }

    public void SetSFXVolume(float value)
    {
        audioMixer.SetFloat("SFXVol", Mathf.Log10(Mathf.Clamp(value, 0.0001f, 1)) * 20);
        PlayerPrefs.SetFloat("SFXVol", value);
    }

    private void LoadVolumes()
    {
        float master = PlayerPrefs.GetFloat("MasterVol", 1f);
        float bgm = PlayerPrefs.GetFloat("BGMVol", 1f);
        float sfx = PlayerPrefs.GetFloat("SFXVol", 1f);

        SetMasterVolume(master);
        SetBGMVolume(bgm);
        SetSFXVolume(sfx);
    }

}