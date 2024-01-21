using UnityEngine;

public class Frienemy : MonoBehaviour
{
    public float acceleration = 0.2f;

    public float flySpeed = 8f;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-flySpeed, 0);
    }

    private void Update()
    {
        flySpeed += acceleration * Time.deltaTime;
    }
}
