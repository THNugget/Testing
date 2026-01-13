using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private PlayerStats stats;

    private Vector2 movement;

    private Rigidbody2D rb;
    public bool canMove = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        stats = GetComponent<PlayerStats>();
    }

    // Update is called once per frame
    void Update()
    {
        if(canMove)
        {
            rb.linearVelocity = movement * stats.speed;
        }
        else
        {
            rb.linearVelocity = Vector2.zero;
        }
    }

    public void Move(InputAction.CallbackContext ctx)
    {
        movement = ctx.ReadValue<Vector2>();
    }
}
