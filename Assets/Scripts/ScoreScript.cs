using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public Text scoreText;
    public Text highscoreText;
    public int highscore;

    private void Start()
    {
        highscore = PlayerPrefs.GetInt("Highscore");
        highscoreText.text = "Highscore:" + highscore;
    }

    public void UpdateScore(int score)
    {
        scoreText.text = score.ToString();
    }

    public void PassHighScore(int score)
    {
        if (highscore < score)
        {
            highscore = score;
            PlayerPrefs.SetInt("Highscore", highscore);
            Debug.Log(PlayerPrefs.GetInt("Highscore"));
        }

        highscoreText.text = "Highscore:" + highscore;

        PlayerPrefs.SetInt("Highscore", highscore);
    }
}
