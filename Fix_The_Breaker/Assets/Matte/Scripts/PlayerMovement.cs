using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float Speed = 8f;
    private Vector2 moveDirection;

    public Rigidbody2D rb;


    void Update()
    {
        float MouseX = Input.GetAxisRaw("Horizontal");
        float MouseY = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector2(MouseX, MouseY).normalized;
    }

    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(moveDirection.x * Speed, moveDirection.y * Speed);
    }
}
 