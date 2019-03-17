using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterDamage : MonoBehaviour {
    // Use this for initialization
    float lastTimeHit;

	void Start () {
        lastTimeHit = Time.realtimeSinceStartup;	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Enemies")) {
            if (Time.realtimeSinceStartup - lastTimeHit > 2) {
            Debug.Log("adfdsfa");
                other.GetComponent<EnemyAI>().healthMonster -= 50;
            }
        }
    }
}
