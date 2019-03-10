using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotateAround : MonoBehaviour
{

    public Transform target;
    private float sensitivity = 3; // чувствительность мышки
    private float xCoordinate;
    private float yCoordinate;
    private float xMinAngle = -70;
    private float xMaxAngle = -15;
    float radius;

    Vector3 cameraRelativeToCharacter;

    void Start()
    {
        xCoordinate = -transform.eulerAngles.x;
        yCoordinate = transform.eulerAngles.y;
        radius = Vector3.Magnitude(new Vector3(transform.position.x-target.position.x, transform.position.y - target.position.y, transform.position.z- target.position.z));
        transform.localEulerAngles = new Vector3(-xCoordinate, yCoordinate, 0);
        cameraRelativeToCharacter = -target.transform.InverseTransformVector(transform.forward).normalized * radius;
        transform.position = target.position + cameraRelativeToCharacter;
    }

    void Update()
    {
        if (Input.GetMouseButton(0)) {
            xCoordinate += Input.GetAxis("Mouse Y") * sensitivity;
            xCoordinate = Mathf.Clamp(xCoordinate, xMinAngle, xMaxAngle);
            yCoordinate += Input.GetAxis("Mouse X") * sensitivity;
            transform.localEulerAngles = new Vector3(-xCoordinate, yCoordinate, 0);
            cameraRelativeToCharacter = -target.transform.InverseTransformVector(transform.forward);
            cameraRelativeToCharacter = cameraRelativeToCharacter.normalized*radius;
            transform.position = target.position + cameraRelativeToCharacter;
        }

    }
}