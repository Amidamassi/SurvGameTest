using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCraft : MonoBehaviour
{
    bool tryToCraft = false;
    bool showCraft = false;
    GameObject campFire;
    // Start is called before the first frame update
    void Start()
    {
        campFire = Resources.Load<GameObject>("Craft/CampFire");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K)) { tryToCraft = true; }
        if (tryToCraft) {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit)) {
                if (!showCraft) {
                    campFire.transform.position = hit.point;
                    campFire.GetComponent<BoxCollider>().enabled = false;
                    campFire = Instantiate(campFire);
                    showCraft = true;
                }
                if (showCraft) {
                    campFire.transform.position = hit.point;
                    if (Input.GetKeyDown(KeyCode.Mouse0)) {
                        tryToCraft = false;
                        showCraft = false;
                        campFire.GetComponent<BoxCollider>().enabled = true;
                        campFire = Resources.Load<GameObject>("Craft/CampFire");
                    }
                }
                if (Input.GetKeyDown(KeyCode.Escape)) {
                    tryToCraft = false;
                }
            }
        }
            
        
    }
}
