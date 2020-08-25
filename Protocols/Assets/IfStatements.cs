using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{
	float coffeeTemperature = 85.0f; 
    float hotlimitTemperature = 70.0f; 
    float coldLimitTemperature = 40.0f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();

        coffeeTemperature -= Time.deltaTime * 5f; 
    }	

    void TemperatureTest()
    {
        if (coffeeTemperature > hotlimitTemperature)
        {
            print("Coffee is too hot.");
        }
        else if (coffeeTemperature < coldLimitTemperature)
        {
            print("Coffee is too freakin cold.");
        }
        else
        {
            print("Coffee is just right.");
        }
    }
}
