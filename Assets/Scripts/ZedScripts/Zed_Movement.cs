using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zed_Movement : MonoBehaviour
{
    public float zedSpeed; 
    public Rigidbody  rb;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float hAxis = Input.GetAxis("Horizontal");
        float zAxis = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(hAxis, 0, zAxis * zedSpeed * Time.deltaTime);
        rb.MovePosition(transform.position + movement);
    }
}
