using UnityEngine;
using UnityEngine.UI;

public class LifeDeath : MonoBehaviour
{
    public GameObject playerObj;
    public GameObject frienemyspawnerObj;
    public GameObject ingameOverlayUI;
    public GameObject deathMenuOverlayUI;
    public GameObject ScreenClearer;

    public Rigidbody2D playerrb;

    public AudioSource DeathSfx;
    public AudioSource DeathMusic;
    public AudioSource GameMusic;

    public Image heart1;
    public Image heart2;
    public Image heart3;

    private int lifes = 3;

    private void Update()
    {
        HandleLifeGraphics();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.gameObject.CompareTag("Frienemy")) return;

        DeathSfx.Play();
        lifes--;
        Destroy(collision.gameObject, 0.25f);
    }

    private void HandleLifeGraphics()
    {
        switch (lifes)
        {
            case 3:
                heart1.enabled = true;
                heart2.enabled = true;
                heart3.enabled = true;
                break;
            case 2:
                heart1.enabled = true;
                heart2.enabled = true;
                heart3.enabled = false;
                break;
            case 1:
                heart1.enabled = false;
                heart2.enabled = true;
                heart3.enabled = false;
                break;
            case 0:
                heart1.enabled = false;
                heart2.enabled = false;
                heart3.enabled = false;


                DeathMusic.enabled = true;
                GameMusic.enabled = false;

                playerrb.constraints = RigidbodyConstraints2D.FreezePositionY;
                playerObj.GetComponent<Collider2D>().enabled = false;
                playerObj.GetComponent<PlayerMovement>().enabled = false;
                frienemyspawnerObj.SetActive(false);
                ingameOverlayUI.SetActive(false);
                deathMenuOverlayUI.SetActive(true);
                ScreenClearer.SetActive(true);
                break;
        }
    }

    public void setlifesDefault()
    {
        lifes = 3;
    }
}
