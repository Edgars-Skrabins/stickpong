using UnityEngine;

public class Collisions : MonoBehaviour
{
    public AudioSource[] audios;

    private int score;

    private ScoreScript scoreScript;

    private void Awake()
    {
        scoreScript = FindObjectOfType<ScoreScript>();
    }

    private void OnTriggerEnter2D(Collider2D Collision)
    {
        if (!Collision.gameObject.CompareTag("Frienemy")) return;

        ImpactSound();
        Destroy(Collision.gameObject);
        score++;
        scoreScript.UpdateScore(score);
        scoreScript.PassHighScore(score);
    }

    public void ResetScore()
    {
        score = 0;
    }

    private void ImpactSound()
    {
        int randomImpactSfx = Random.Range(0, audios.Length);
        audios[randomImpactSfx].Play();
    }
}
