using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public Transform player;
    public float enemySpeed = 3f;
    //private bool isChasing = true;
    public CircleCollider2D radius;
    public LayerMask playerMask;
    private bool hasLineOfSight = false;
    private bool isChasing = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (hasLineOfSight && isChasing)
        {
            Vector2 direction = (player.position - transform.position).normalized;
            rb.linearVelocity = direction * enemySpeed;
            direction.Normalize();
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(Vector3.forward * angle);
        }

        else
        {
            rb.linearVelocity = Vector2.zero;
        }

        //RaycastHit2D ray = Physics2D.Raycast(transform.position, player.transform.position - transform.position);
        //if (ray.collider != null)
        //{

        //    //if(ray.collider.gameobject.layer == layermask.nametolayer("player"))
        //    //{
        //    //    haslineofsight = true;
        //    //}
        //    //else
        //    //{
        //    //    haslineofsight = false;
        //    //}
        //    hasLineOfSight = ray.collider.CompareTag("Player");
        //    if (hasLineOfSight)
        //    {
        //        Debug.DrawRay(transform.position, player.transform.position - transform.position, Color.green);
        //    }
        //    else
        //    {
        //        Debug.DrawRay(transform.position, player.transform.position - transform.position, Color.red);
        //    }
        //}
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            isChasing = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            isChasing = false;
        }
    }

    private void FixedUpdate()
    {
        RaycastHit2D ray = Physics2D.Raycast(transform.position, player.transform.position - transform.position, 100, playerMask);
        if (ray.collider != null)
        {

            //if(ray.collider.gameobject.layer == layermask.nametolayer("player"))
            //{
            //    haslineofsight = true;
            //}
            //else
            //{
            //    haslineofsight = false;
            //}
            hasLineOfSight = ray.collider.CompareTag("Player");
            if (hasLineOfSight)
            {
                Debug.DrawRay(transform.position, player.transform.position - transform.position, Color.green);
            }
            else
            {
                Debug.DrawRay(transform.position, player.transform.position - transform.position, Color.red);
            }
        }
    }
}
