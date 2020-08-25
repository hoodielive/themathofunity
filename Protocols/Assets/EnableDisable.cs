using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableDisable : MonoBehaviour
{
    Light myLight;
		
    void Start()
    {
        myLight = GetComponent<Light>();
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            // Toggle the Light.
            myLight.enabled = !myLight.enabled;
        }
    }
}
