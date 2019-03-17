using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTest : MonoBehaviour
{

    public Transform target;
    private float sensitivity = 3; // чувствительность мышки
    private float xCoordinate;
    private float yCoordinate;
    private float xMinAngle = -70;
    private float xMaxAngle = -15;
    float radius;
    private Vector3 offset;

    Vector3 cameraRelativeToCharacter;

    void Start()
    {
        xCoordinate = -transform.eulerAngles.x;
        yCoordinate = transform.eulerAngles.y;
        radius = Vector3.Magnitude(transform.position-target.position);
        transform.localEulerAngles = new Vector3(-xCoordinate, yCoordinate, 0);
        cameraRelativeToCharacter = -target.transform.InverseTransformVector(transform.forward).normalized * radius;
        offset = target.position;
    }

    void Update()
    {
        if (Input.GetMouseButton(0)) {
            xCoordinate += Input.GetAxis("Mouse Y") * sensitivity;
            xCoordinate = Mathf.Clamp(xCoordinate, xMinAngle, xMaxAngle);
            yCoordinate += Input.GetAxis("Mouse X") * sensitivity;
            transform.eulerAngles = new Vector3(-xCoordinate, yCoordinate, 0);
            cameraRelativeToCharacter = -transform.forward;
            cameraRelativeToCharacter = cameraRelativeToCharacter*radius;
            transform.position = target.position +cameraRelativeToCharacter;
        }
        transform.Translate (target.position - offset,Space.World);
        Debug.Log(target.position - offset);
        offset = target.position;
    }
}