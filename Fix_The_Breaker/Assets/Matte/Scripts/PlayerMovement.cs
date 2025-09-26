using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float Speed = 8f;
    private Vector2 moveDirection;

    public Rigidbody2D rb;
    public Transform playerBody;


    void Update()
    {
        //Parralax

        //Movement
        float MovementX = Input.GetAxisRaw("Horizontal");
        float MovementY = Input.GetAxisRaw("Vertical");
        

        moveDirection = new Vector2(MovementX, MovementY).normalized;
    }

    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(moveDirection.x * Speed, moveDirection.y * Speed);
    }

    void ParralaxEffekt()
    {
        if (Input.GetButtonDown("W"))
        { 
            transform.localScale = new Vector3(1, 1, 1);
        }
    }
}
 