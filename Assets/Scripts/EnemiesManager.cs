using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesManager : MonoBehaviour
{
    GameObject[] enemies;
    // Start is called before the first frame update
    void Start()
    {
        enemies = Resources.LoadAll<GameObject>("Enemies");
        for (int i = 0; i < enemies.Length; i++) {
            enemies[i].transform.position = new Vector3((float) i+3, (float) i+1, (float) i+1);
            Instantiate(enemies[i]);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
