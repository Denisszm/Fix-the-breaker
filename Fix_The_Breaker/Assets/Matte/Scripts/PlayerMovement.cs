using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float Speed = 8f;
    private Vector2 moveDirection;

    public Rigidbody2D rb;

    public float changeScale = 1;
    


    void Update()
    {
        //Movement
        float MovementX = Input.GetAxisRaw("Horizontal");
        float MovementY = Input.GetAxisRaw("Vertical");
        

        moveDirection = new Vector2(MovementX, MovementY).normalized;

        if (MovementY > 0 || MovementY < 0)
            transform.localScale = new Vector3(rb.position.y * changeScale, rb.position.y * changeScale, 1);
    }

    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(moveDirection.x * Speed, moveDirection.y * Speed);

    }
}
 