using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    private HighScore highScore;
    public GameObject panel;
    public Text ScoreText;
    public Text HighScoreText;

    // Use this for initialization
    void Start()
    {
        panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            DisplayTime(other);
        }
    }


    private void DisplayTime(Collision other)
    {
        highScore = other.gameObject.GetComponent<HighScore>();
        Time.timeScale = 0f;
        panel.SetActive(true);
        Cursor.visible = true;
        float ScoreTime = Time.timeSinceLevelLoad;
        ScoreText.text = "Score: " + ScoreTime.ToString("0.00") + " Seconds";

        highScore.SetHighScore(SceneManager.GetActiveScene().name, ScoreTime);
        float highScoreTime = highScore.GetHighScore(SceneManager.GetActiveScene().name);

        HighScoreText.text = "Highscore: " + highScoreTime.ToString("0.00") + " Seconds";
    }
}
