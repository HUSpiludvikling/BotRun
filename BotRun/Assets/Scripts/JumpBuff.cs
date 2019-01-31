using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class JumpBuff : MonoBehaviour {
    public float Height;
    public float Duration;

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
            other.gameObject.GetComponent<RigidbodyFirstPersonController>().AddJumpHeight(Height, Duration);
            Destroy(gameObject);
        }
    }
}
