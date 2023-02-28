using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollows : MonoBehaviour
{
    public Transform target;
    private Vector3 offset;

    public float rotationSpeed = 10f;
    public float maxVerticalRotation = 80f;

    private float horizontalRotation = 0f;
    private float verticalRotation = 0f;

    // Start is called before the first frame update
    private void Start()
    {
        offset = transform.position - target.position;
    }

    // Update is called once per frame
    private void Update()
    {
        transform.position = new Vector3(target.position.x + offset.x, target.position.y + offset.y, target.position.z + offset.z);

        float mouseX = Input.GetAxis("Mouse X") * rotationSpeed;
        float mouseY = Input.GetAxis("Mouse Y") * rotationSpeed;

        horizontalRotation += mouseX;
        verticalRotation -= mouseY;
        verticalRotation = Mathf.Clamp(verticalRotation, -maxVerticalRotation, maxVerticalRotation);

        transform.localRotation = Quaternion.Euler(verticalRotation, horizontalRotation, 0f);
    }
}