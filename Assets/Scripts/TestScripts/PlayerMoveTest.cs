using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveTest : MonoBehaviour
{
    float speedMove = 10f;
    float speedRotation = 10f;
    RaycastHit hit;
    bool hasPosition = false;
    bool run;

    void Update()
    {

        //GetComponent<Animator>().Play("ArmatureAction");

        if (Input.GetKeyDown(KeyCode.Mouse1)) {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit)) {
                hasPosition = true;
            }
        }
        if (hasPosition) {
            GetComponent<Animator>().SetBool("Run", true);
            //transform.rotation = Quaternion.Lerp(transform.rotation, transform.LookAt, 1);
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(hit.point - transform.position), Time.deltaTime * speedRotation);

            transform.position = Vector3.Lerp(transform.position, hit.point, speedMove * Time.deltaTime / Vector3.Distance(transform.position, hit.point));

            if (Vector3.Distance(transform.position, hit.point) == 0) {
                hasPosition = false;
                GetComponent<Animator>().SetBool("Run", false);
            }
        }
    }
    //IEnumerable PlayerMove() {
    //    transform.position = Vector3.Lerp(transform.position, hit.point, 0.1f);
    //}
}
   
