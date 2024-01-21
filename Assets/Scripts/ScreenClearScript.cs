using UnityEngine;

public class ScreenClearScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D Collision)
    {
        if (Collision.gameObject.CompareTag("Frienemy"))
        {
            Destroy(Collision.gameObject);
        }
    }
}