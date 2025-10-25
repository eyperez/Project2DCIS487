using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    // Start is called once fore the first execution of Update after the MonoBehaviour is created

    public float speed = 2f;
    private Transform player;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            Vector3 targetPosition = player.position;
            targetPosition.y = transform.position.y;
            Vector2 direction = (player.position - transform.position).normalized;
            transform.position += (Vector3)direction * speed * Time.deltaTime;
        }
    }
}
