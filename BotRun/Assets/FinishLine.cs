using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour {
    private HighScore highScore;
    public GameObject panel;
    public Text ScoreText;
    public Text HighScoreText;

	// Use this for initialization
	void Start () {
        panel.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<HighScore>();
            Time.timeScale = 0f;
            panel.SetActive(true);
            Cursor.visible = true;
            ScoreText.text = "Score: " + Time.timeSinceLevelLoad.ToString(".3");
            HighScoreText.text = "High Score:" + other.gameObject.GetComponent<HighScore>().GetHighScore(SceneManager.GetActiveScene().name);
        }
    }
}
