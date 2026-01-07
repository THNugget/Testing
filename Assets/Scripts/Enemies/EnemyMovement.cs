using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public Transform player;
    public float enemySpeed = 3f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = (player.position - transform.position).normalized;
        rb.linearVelocity = direction * enemySpeed;
    }
}
