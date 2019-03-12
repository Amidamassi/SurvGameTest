using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    float targ_pos;
    Vector3 direction;
    public float speed;
    RaycastHit hit;
    List<string> itemsInInventory = new List<string>();
    bool objectHit = false;

    void Start()
    {
        targ_pos = 0;
        //hit = new RaycastHit();
        //TextAsset loadedText = Resources.Load<TextAsset>("DataBase");
        //string s = loadedText.text;
        //Debug.Log(s);
        //GameObject player = Resources.Load<GameObject>("Player");
        //GetComponent<Material>().mainTexture = sprite.mainTexture; //(sprite);
        //Instantiate(player);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1)) {

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit)) {
                targ_pos = Vector3.Distance(transform.position, hit.point);
                objectHit = true;
            } else { objectHit = false; }

        }
        if (Input.GetKeyDown(KeyCode.Space)) {
            for (int i = 0; i < itemsInInventory.Count; i++) {
                Debug.Log(itemsInInventory[i]);
            }
        }
        if (objectHit) {
            if (hit.collider.tag.Equals("Enemies") && targ_pos < 2) {
                Debug.Log("You kill the " + hit.collider.name);
                Destroy(hit.collider.gameObject);
                targ_pos = 0;
                objectHit = false;
            }
            else if (hit.collider.tag.Equals("Items") && targ_pos < 2) {
                Debug.Log("You earn the " + hit.collider.name);
                itemsInInventory.Add(hit.collider.name);
                Destroy(hit.collider.gameObject);
                targ_pos = 0;
                objectHit = false;
            } else {
                direction = hit.point - transform.position;
                if (targ_pos > speed) {
                    transform.Translate(direction.normalized * speed, Space.World);
                    targ_pos = targ_pos - speed;
                }
            }
        }
        //if (targ_pos > speed) {
        //    transform.Translate(direction.normalized * speed, Space.World);
        //    targ_pos = targ_pos - speed;
        //} else {
        //    transform.Translate(0, 0, 0, Space.World);
        //}
    }

    private void OnTriggerEnter(Collider other)
    {
        //if (other.tag.Equals("Items")) {
            //Debug.Log("You earn " + other.name);
            //itemsInInventory.Add(other.name);
            //Debug.Log(resoursesInInventory.Count);
        //}
        //if (other.tag.Equals("Enemies")) {
            //Debug.Log("You hit " + other.name);
            //itemsInInventory.Add(other.name);
            //Debug.Log(resoursesInInventory.Count);
        //}
    }
    
}
