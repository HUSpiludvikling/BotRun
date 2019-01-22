using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class SpeedBuff : MonoBehaviour {
    public float Duration;
    public float Speed;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.gameObject.GetComponent<RigidbodyFirstPersonController>().AddSpeed(Speed, Duration);
            Destroy(gameObject);
        }
    }
}
