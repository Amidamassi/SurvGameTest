using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotateAround : MonoBehaviour
{

    public Transform target;
    Vector3 offset;
    public float sensitivity = 3; // чувствительность мышки
    //public float limit = 80; // ограничение вращения по Y
    public float zoom = 0.25f; // чувствительность при увеличении, колесиком мышки
    public float zoomMax = 10; // макс. увеличение
    public float zoomMin = 3; // мин. увеличение
    private float X, Y;
    float distanse;
    float radius;
    Vector3 hui;

    void Start()
    {
        offset = transform.position - target.transform.position;
        //limit = Mathf.Abs(limit);
        //if (limit > 90) limit = 90;
        //offset = new Vector3(offset.x, offset.y, -Mathf.Abs(zoomMax)/2);
        //transform.position = target.position + offset;
        radius = Vector3.Magnitude(new Vector3(transform.position.x-target.position.x, 0, transform.position.z- target.position.z));
    }

    void Update()
    {
        //if (Input.GetAxis("Mouse ScrollWheel") > 0) offset.z += zoom;
        //else if (Input.GetAxis("Mouse ScrollWheel") < 0) offset.z -= zoom;
        //offset.z = Mathf.Clamp(offset.z, -Mathf.Abs(zoomMax), -Mathf.Abs(zoomMin));
        if (Input.GetMouseButton(0)) {         
            
            //X = transform.localEulerAngles.x + Input.GetAxis("Mouse X") * sensitivity;
            Y += Input.GetAxis("Mouse X") * sensitivity;
            transform.localEulerAngles = new Vector3(45, -Y, 0);
            distanse = Vector3.Distance(target.position, transform.position);
            hui = -target.transform.InverseTransformVector(transform.forward);
            hui.y = 0;
            hui =hui.normalized*radius;
            transform.position = new Vector3(target.position.x + hui.x, transform.position.y, hui.z+target.position.z);
            //transform.position = new Vector3(target.position.x, transform.position.y, target.position.z);
            //transform.Rotate(new Vector3(0, Y, 0));
            //transform.di
            //transform.localEulerAngles = new Vector3(45, -Y, 0);
            //transform.position = transform.position + Vector3.back * distanse;
            //transform.position = transform.localRotation * offset - target.transform.position;
        }

    }
}