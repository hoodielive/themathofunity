using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslateAndRotate : MonoBehaviour
{
    public float moveSpeed = 10f; 
    public float turnSpeed = 50f; 

    void Update()
    {
        // 0 for x and y

        if (Input.GetKey(KeyCode.UpArrow))
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        
        if (Input.GetKey(KeyCode.DownArrow))
            transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);

    }
		
}
