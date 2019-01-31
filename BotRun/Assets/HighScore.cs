using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScore : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    
    public float GetHighScore(string Level)
    {
        if (PlayerPrefs.HasKey(Level))
        {
            return PlayerPrefs.GetFloat(Level);
        }
        else
        {
            return -1;
        }
    }

    public void SetHighScore(string Level, float HighScore)
    {
        if (HighScore > GetHighScore(Level))
        {
            PlayerPrefs.SetFloat(Level, HighScore);
        }
    }
}
