using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnMouseDownAnd : MonoBehaviour
{
    private Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
	void OnMouseDown() 
    {
        // add force in the inverse direction to its forward
        rb.AddForce(-transform.forward * 500f);
        rb.useGravity = true; 
    }	
}
