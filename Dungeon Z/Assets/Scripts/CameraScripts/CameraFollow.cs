using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    private Vector3 camOffset;

    [Range(0.01f, 1.0f)]
    public float smoothFactor = 0.5f;

    public bool lookAtPlayer = false;

     void Start()
    {
        camOffset = transform.position - target.position; 
    }

    void LateUpdate()
    {
        Vector3 newPos = target.position + camOffset;
        transform.position = Vector3.Slerp(transform.position, newPos, smoothFactor);

        if(lookAtPlayer)
        {
            transform.LookAt(target);
        }
    }
}
