using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Vector2 mouseTurn;
    public float sensitivity = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;   
    }

    // Update is called once per frame
    void Update()
    {
        mouseTurn.x += Input.GetAxis("Mouse X") * sensitivity;
        mouseTurn.y += Input.GetAxis("Mouse Y") * sensitivity;
        transform.rotation = Quaternion.Euler(-mouseTurn.y, mouseTurn.x, 0); 
    }
}
