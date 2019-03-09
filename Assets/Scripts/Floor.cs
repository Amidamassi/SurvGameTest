using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour
{
    public GameObject player;
    public Camera playerCamera;
    float speed = 0.1f;
    float targ_pos;
    Vector3 direction;
    // Start is called before the first frame update
    void Start()
    {
       targ_pos = 0;
    }
    private void OnMouseDown()
    {
        //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //RaycastHit hit;

        //if (Physics.Raycast(ray, out hit, Mathf.Infinity)) {
        //    Vector3 direction = hit.point - player.transform.position;
        //    float targ_pos = Vector3.Distance(player.transform.position, hit.point);
        //    while (targ_pos > 1) {
        //        player.transform.Translate(direction * speed, Space.World);
        //        targ_pos = Vector3.Distance(player.transform.position, hit.point);
        //    }

        //}
        //RaycastHit hit;

        //if (Physics.Raycast(playerCamera.transform.position, playerCamera.transform.position - Input.mousePosition, out hit)) {
        //    player.transform.position = hit.point;
        //    Debug.DrawRay(playerCamera.transform.position, hit.point, Color.yellow);
        //}
    }
    // Update is called once per frame
    void Update()
    {
        if (targ_pos > speed) {
            player.transform.Translate(direction * speed, Space.World);
            targ_pos = targ_pos - speed;
        } else {
            player.transform.Translate(0,0,0, Space.World);
        }
        if (Input.GetKeyDown(KeyCode.Mouse0)) {
        
         Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
         RaycastHit hit;

         if (Physics.Raycast(ray, out hit)) {
              direction = hit.point - player.transform.position;
              targ_pos = Vector3.Distance(player.transform.position, hit.point);
              if (targ_pos > speed) {
                  player.transform.Translate(direction * speed, Space.World);
                  targ_pos = targ_pos - speed;
              }
            }
        }

    }
}
