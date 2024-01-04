using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance {get; private set;}

    // Start is called before the first frame update
    void Start()
    {
        // If the Instance var is empty
        if (Instance == null)
        {
            Instance = this;
        } else {

            Debug.LogWarning("There cannot be more than one instance of GameManager!");
            Destroy(gameObject);
        }
    }

}
