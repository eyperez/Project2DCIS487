using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [Header("ADUIO SOURCE")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    [Header("AUDIO CLIP")]
    public AudioClip background;
    public AudioClip defeat;


    private void Start()
    {
        musicSource.clip = background;
        musicSource.Play();
    }

}
