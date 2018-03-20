using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zed_Jump : MonoBehaviour
{
    public float fallMultiplier;
    public float lowJumpMultiplier;
    public float jumpVelocity; 

    Rigidbody rb;


    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
   
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetButton("Jump"))
        {
            Jump();
        }

        if (rb.velocity.y < 0)
        {
            rb.velocity += Vector3.up * Physics.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
        }
        else if (rb.velocity.y > 0 && Input.GetButton("Jump"))
        {
            rb.velocity += Vector3.up * Physics.gravity.y * (lowJumpMultiplier - 1) * Time.deltaTime;
        }

       
        
	}

    void Jump()
    {
        {
            GetComponent<Rigidbody>().velocity = Vector3.up * jumpVelocity;
        }
    }
   
}
