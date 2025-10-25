using UnityEngine;

public class CoinCollect : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [Header("Audio")]
    public AudioSource coinSound;

    private void Start()
    {
        coinSound = GetComponent<AudioSource>();

    }

    private void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D.gameObject.CompareTag("Coin"))
        {
            coinSound.Play();
            Destroy(collider2D.gameObject);
        }
        
    }
}
