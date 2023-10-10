using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorController : MonoBehaviour
{

    public Vector3 screenPos;
    public Vector3 worldPos;
    public LayerMask screen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        screenPos = Input.mousePosition;

        Ray ray = Camera.main.ScreenPointToRay(screenPos);

        if(Physics.Raycast(ray, out RaycastHit hitInfo, 100, screen))
        {
            worldPos = hitInfo.point;
        }
        else
        {
            worldPos = Vector3.zero;
        }
        worldPos.z -= 0.15f;

        transform.position = worldPos;
    }
}
