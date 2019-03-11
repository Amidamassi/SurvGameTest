using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ItemsCraft: PlayerCraft
{
    GameObject Item;
    List<string> ResForCraft = new List<string>();
    
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) {
            itemToCraftName = "CampFire";
        }
        if (Input.GetKeyDown(KeyCode.Alpha2)) {
            itemToCraftName = "Tent";
        }
        if (Input.GetKeyDown(KeyCode.Alpha3)) {
            itemToCraftName = "Backpack";
        }
        if (Input.GetKeyDown(KeyCode.Alpha4)) {
            itemToCraftName = "Club";
        }
        if (Input.GetKeyDown(KeyCode.Alpha5)) {
            itemToCraftName = "Axe";
        }
    }
}
