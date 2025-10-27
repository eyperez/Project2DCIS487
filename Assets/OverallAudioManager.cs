using UnityEngine;

public class OverallAudioManager : MonoBehaviour
{
    public static OverallAudioManager instance;

    [Range(0f,1f)]
    public float masterVolume = 1f;

    public void Awake()
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

        AudioListener.volume = masterVolume;
        masterVolume = PlayerPrefs.GetFloat("MasterVolume", 1f);
        AudioListener.volume = masterVolume;
    }

   private void SetVolume(float volume)
    {
        masterVolume = volume;
        AudioListener.volume = masterVolume;

        PlayerPrefs.SetFloat("MasterVolume", masterVolume);
        PlayerPrefs.Save();
    }

    
}


