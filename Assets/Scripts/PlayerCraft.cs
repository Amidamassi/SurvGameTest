using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCraft : MonoBehaviour
{
    public static string itemToCraftName = "Nothing";
    bool tryToCraft = false;
    bool showCraft = false;
    GameObject itemToCraft;
    // Start is called before the first frame update
    void Start()
    {
        //itemToCraft = Resources.Load<GameObject>("Craft/CampFire");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(itemToCraftName);
        if (Input.GetKeyDown(KeyCode.K)) { tryToCraft = true; }
        if (!itemToCraftName.Equals("Nothing")){
            TryToCraftItem(itemToCraftName);
        }
        
    }
    public void TryToCraftItem(string itemToMakeCraft) {
        if (itemToCraft == null) {
            itemToCraft = Resources.Load<GameObject>("Craft/" + itemToMakeCraft);
        }
        if (tryToCraft) {
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
                    if (Input.GetKeyDown(KeyCode.Mouse0)) {
                        tryToCraft = false;
                        showCraft = false;
                        itemToCraft.GetComponent<MeshCollider>().enabled = true;
                        itemToCraft = null;
                        itemToCraftName = "Nothing";
                    }
                }

            }
        }
        if (Input.GetKeyDown(KeyCode.Escape)) {
            Destroy(itemToCraft);
            itemToCraft = null;
            itemToCraftName = "Nothing";
        }
    }
}
