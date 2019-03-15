using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCraft : MonoBehaviour
{
    private static string itemToCraftName = "Nothing";
    private static bool showCraft = false;
    private static bool newItem = true;
    GameObject itemToCraft;

    void Update()
    {
        if (!itemToCraftName.Equals("Nothing")){
            TryToCraftItem(itemToCraftName);
        }
        
    }
    public void TryToCraftItem(string itemToMakeCraft) {
        if (newItem) {
            itemToCraft = Resources.Load<GameObject>("Craft/" + itemToMakeCraft);
            newItem = false;
        }
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit)) {
                if (!showCraft) {
                    itemToCraft.transform.position = hit.point;
                    itemToCraft.GetComponent<MeshCollider>().enabled = false;
                    itemToCraft = Instantiate(itemToCraft);
                    showCraft = true;
                }
                if (showCraft) {
                    itemToCraft.transform.position = hit.point;
                    if (Input.GetKeyDown(KeyCode.Mouse2)) {
                        showCraft = false;
                        itemToCraft.GetComponent<MeshCollider>().enabled = true;
                        itemToCraft = null;
                        itemToCraftName = "Nothing";
                    }
                }

            }

        if (Input.GetKeyDown(KeyCode.Escape)) {
            Destroy(itemToCraft);
            itemToCraft = null;
            itemToCraftName = "Nothing";
            showCraft = false;
        }
    }
    private void DestroyItem()
    {
        Destroy(itemToCraft);
        itemToCraft = null;
        showCraft = false;
        newItem = true;
    }
    public void ItemChangeName(string name)
    {
        Debug.Log(name);
        itemToCraftName = name;
        DestroyItem();
    }
}
