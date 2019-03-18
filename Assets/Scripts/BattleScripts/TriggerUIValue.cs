using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerUIValue : MonoBehaviour {
    public int ValueDown;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Player")) {
            other.GetComponent<PlayerHPScript>().HP += ValueDown;
        }
    }
}
