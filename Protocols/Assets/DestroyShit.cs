using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyShit : MonoBehaviour
{
	void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            // Destroy(gameObject, 3f); Time delayed by 3secs.
            // Destroy(other);
            Destroy(GetComponent<MeshRenderer>());
        }
    }	
}
