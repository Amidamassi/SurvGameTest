using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCraft : MonoBehaviour
{
    public static string itemToCraftName = "Nothing";
    bool showCraft = false;
    GameObject itemToCraft;

    void Update()
    {
        if (!itemToCraftName.Equals("Nothing")){
            TryToCraftItem(itemToCraftName);
        }
        
    }
    public void TryToCraftItem(string itemToMakeCraft) {
        if (itemToCraft == null) {
            itemToCraft = Resources.Load<GameObject>("Craft/" + itemToMakeCraft);
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
        }
    }
    public void ItemChangeName(string name)
    {
        itemToCraftName = name;
    }
}
