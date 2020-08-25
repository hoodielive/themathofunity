using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetComponentAnd : MonoBehaviour
{
    public GameObject otherGameObject; 

    private AnotherScript _anotherScript; 
    private YetAnotherScript _yetAnotherScript; 
    
    private BoxCollider boxCol; 

    void Awake()
    {
        _anotherScript = GetComponent<AnotherScript>();
        _yetAnotherScript = GetComponent<YetAnotherScript>();
        boxCol = otherGameObject.GetComponent<BoxCollider>();
    }

    void Start()
    {
        boxCol.size = new Vector3(3, 3, 3);
        Debug.Log($"The player's score is: {_anotherScript.playerScore}");
        Debug.Log($"The player has died: {_yetAnotherScript.numberOfPlayerDeaths} times");
    }
}
