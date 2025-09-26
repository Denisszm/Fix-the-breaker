using UnityEngine;

public class Olaf_Player_Movement : MonoBehaviour
{
    public float Speed = 8f;
    private Vector2 moveDirection;

    public Rigidbody2D rb;

    // Update is called once per frame
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
