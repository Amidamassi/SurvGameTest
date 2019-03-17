using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHPScript : MonoBehaviour {
    float HP = 100f;
    public Text enemyHP;
	// Use this for initialization
	void Start () {
        enemyHP.text = "EnemyHP: " + ((int)HP).ToString();
	}
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Player")) {
            HP--;
            enemyHP.text = ((int)HP).ToString();
        }
    }
    // Update is called once per frame
    void Update () {
		
	}
}
