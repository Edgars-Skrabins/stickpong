using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float acceleration = 0.5f;

    public Rigidbody2D playerRb;

    public float moveSpeed = 100f;

    public Vector2 movement;

    private void Update()
    {
        movement = new Vector2(0, Input.GetAxisRaw("Vertical"));
    }

    private void FixedUpdate()
    {
        playerRb.velocity = movement * moveSpeed;
    }

    private void update()
    {
        moveSpeed += acceleration * Time.deltaTime;
    }
}