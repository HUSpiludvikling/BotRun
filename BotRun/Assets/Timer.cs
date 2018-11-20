using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
    float Clock;
    public Text TextTime;

	// Use this for initialization
	void Start () {
        Clock = 0;
	}
	
	// Update is called once per frame
	void Update () {
        Clock += Time.deltaTime;
        TextTime.text = Clock.ToString();
	}
}
