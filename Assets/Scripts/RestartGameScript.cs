using UnityEngine;

public class RestartGameScript : MonoBehaviour
{
    public GameObject playerObj;
    public GameObject frienemySpawnerObj;
    public GameObject ingameOverlayUI;
    public GameObject deathMenuOverlayUI;
    public Transform playerlocation;
    public GameObject screenClearer;

    public Rigidbody2D playerrb;

    public AudioSource deathSfx;
    public AudioSource deathMusic;
    public AudioSource gameMusic;

    private Vector3 defaultlocation = new Vector3(-9.543064f, 0f, -6.73141f);
    private Collisions gollisionsScript;

    private int score;

    private ScoreScript scoreScript;


    private void Awake()
    {
        gollisionsScript = FindObjectOfType<Collisions>();
        scoreScript = FindObjectOfType<ScoreScript>();
    }

    public void RestartGame()
    {
        playerlocation.position = defaultlocation;

        playerObj.GetComponent<Collider2D>().enabled = true;
        playerObj.GetComponent<PlayerMovement>().enabled = true;
        frienemySpawnerObj.SetActive(true);
        ingameOverlayUI.SetActive(true);
        deathMenuOverlayUI.SetActive(false);
        screenClearer.SetActive(false);

        playerrb.constraints &= ~RigidbodyConstraints2D.FreezePositionY;

        gameMusic.enabled = true;
        deathMusic.enabled = false;
        deathSfx.enabled = true;
        score = 0;
        scoreScript.UpdateScore(score);
    }
}
