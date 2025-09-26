using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float Horizontal;
    private float Speed = 8f;
    private float JumpingPower = 16f;
    private bool IsFacingRight = true;

    private Rigidbody2D rb;
    private Transform groundCheck;
    private LayerMask groundLayer;

    void Start()
    {
        rb.freezeRotation = true;
    }
    void Update()
    {
        Horizontal = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(Horizontal * Speed, rb.linearVelocity.y);
    }
}
 