using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public Vector3 rotationAxis = Vector3.up; // Axis to rotate around (Y-axis)
    public float rotationSpeed = 30f;        // Speed of rotation (degrees per second)

    void Update()
    {
        // Rotate the object around its local center
        transform.Rotate(rotationAxis, rotationSpeed * Time.deltaTime, Space.Self);
    }
}