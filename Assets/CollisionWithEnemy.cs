using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionWithEnemy : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Player Hit");
        }
        
    }
}
