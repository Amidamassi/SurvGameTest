using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsManager : MonoBehaviour
{
    GameObject[] items;
    // Start is called before the first frame update
    void Start()
    {
        items = Resources.LoadAll<GameObject>("Items");
        for (int i = 0; i < items.Length; i++) {
            items[i].transform.position = new Vector3((float) i+1, (float) i+1, (float) i+1);
            Instantiate(items[i]);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
