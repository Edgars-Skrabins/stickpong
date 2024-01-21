using UnityEngine;

public class PauseScript : MonoBehaviour
{
    public AudioSource GameMusic;
    public AudioSource DeathMusic;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
            }
            else
            {
                Time.timeScale = 1;
            }
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            if (GameMusic.volume == 0f && DeathMusic.volume == 0f)
            {
                GameMusic.volume = 0.15f;
                DeathMusic.volume = 0.15f;
            }
            else
            {
                GameMusic.volume = 0f;
                DeathMusic.volume = 0f;
            }
        }
    }
}