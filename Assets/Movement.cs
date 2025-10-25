using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Animator animator;
    float horizontalMove = 0f;
    public float runSpeed = 4f;
   

    [Header("Audio")]
    public AudioSource jumpSound;

    [Header("Component")]
    public Rigidbody2D Rb;
    public LayerMask groundLayer;

    [Header("Collision")]
    public bool onGround = false;
    public float groundLine = 0.2f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
        jumpSound = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {

        // Check if on Ground

        onGround = Physics2D.Raycast(transform.position, Vector2.down, groundLine, groundLayer);

        // User Inputs
        bool spaceKey = Input.GetKey(KeyCode.Space);
        bool rightKey = Input.GetKey(KeyCode.RightArrow);
        bool leftKey = Input.GetKey(KeyCode.LeftArrow);

        if (rightKey)
        {
            Debug.Log("Right Key Pressed");
            Rb.AddForce(Vector2.right, ForceMode2D.Impulse);
        }
        if (leftKey)
        {
            Debug.Log("Left Key Pressed");
            Rb.AddForce(Vector2.left, ForceMode2D.Impulse);
        }
        if (spaceKey && onGround)
        {
            Debug.Log("Space Key Pressed");
            Rb.AddForce(Vector2.up * 4, ForceMode2D.Impulse);
            jumpSound.Play();
        }

        // Animation Part
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        if (onGround)
        {
            animator.SetBool("isJumping", false);
        }
        else
        {
            animator.SetBool("isJumping", true);
        }

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

    }

/*    public void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
        if(collision.CompareTag("Coin"))
        {
            coinSound.Play();
        }
    }*/

    /*    public void PlayCoinSound()
        {
            audioSource.PlayOneShot(coinSound);
        }*/

    // private void OnDrawGizmos()
    // {
    //    Gizmos.color = Color.blue;
    //     Gizmos.DrawLine(transform.position, transform.position + Vector3.down * groundLine);
    // }

}
