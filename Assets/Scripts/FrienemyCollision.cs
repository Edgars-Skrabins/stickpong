using UnityEngine;

public class FrienemyCollision : MonoBehaviour
{
    public AudioSource PopSFX;

    private void OnTriggerEnter2D(Collider2D Collision)
    {
        if (Collision.gameObject.CompareTag("Frienemy"))
        {
            Destroy(Collision.gameObject);
        }
    }
}
