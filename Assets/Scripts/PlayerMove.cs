using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    float targ_pos;
    Vector3 direction;
    public float speed;

    void Start()
    {
        targ_pos = 0;
        TextAsset loadedText = Resources.Load<TextAsset>("DataBase");
        string s = loadedText.text;
        Debug.Log(s);
        GameObject player = Resources.Load<GameObject>("Player");
        //GetComponent<Material>().mainTexture = sprite.mainTexture; //(sprite);
        //Instantiate(player);
    }

    void Update()
    {
        if (targ_pos > speed) {
            transform.Translate(direction.normalized * speed, Space.World);
            targ_pos = targ_pos - speed;
        } else {
            transform.Translate(0, 0, 0, Space.World);
        }
        if (Input.GetKeyDown(KeyCode.Mouse0)) {

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit)) {
                direction = hit.point - transform.position;
                targ_pos = Vector3.Distance(transform.position, hit.point);
                if (targ_pos > speed) {
                    transform.Translate(direction.normalized * speed, Space.World);
                    targ_pos = targ_pos - speed;
                }
            }
        }

    }
}
