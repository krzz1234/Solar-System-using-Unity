using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public float Speed = 20.0f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * Input.GetAxis("Vertical") * Time.deltaTime * Speed;
        transform.position += transform.right * Input.GetAxis("Horizontal") * Time.deltaTime * Speed;

        transform.Rotate(Vector3.up, Input.GetAxis("Mouse X") * Time.deltaTime * 360, Space.World);
        transform.Rotate(Vector3.right, -Input.GetAxis("Mouse Y") * Time.deltaTime * 360, Space.Self);
    }
}
