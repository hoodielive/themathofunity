using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveSet : MonoBehaviour
{
    public GameObject myObject; 

    void Start()
    {
        Debug.Log($"Active self: {myObject.activeSelf}");
        Debug.Log($"Active in Hiearchy: {myObject.activeInHierarchy}");
    }
}
