using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{

    private Transform cameraTransform;
    private Vector3 lastPos;

    // Start is called before the first frame update
    void Start()
    {
        cameraTransform = Camera.main.transform;
        lastPos = cameraTransform.position;
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 deltaMovement = cameraTransform.position - lastPos;

        // move the X only
        transform.position = new Vector2(transform.position.x+deltaMovement.x * 0.5f, transform.position.y + deltaMovement.y);

        lastPos = cameraTransform.position;
        
    }
}
