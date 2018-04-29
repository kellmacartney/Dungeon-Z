using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemybehaviour : MonoBehaviour
{
    public float speed;
    public float rotateAngle; 

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        Move(); 
	}

    public void Move()
    {
        transform.Translate((Vector3.forward * speed) * Time.deltaTime);
    }


    public void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.CompareTag ("patrolpoint"))
        {
            print("hit");
            transform.Rotate(0, 180, 0);
        }
    }
}
