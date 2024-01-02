using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camra : MonoBehaviour
{
    public Transform followtarget;
    public Vector3 posOffset;

    // Update is called once per frame
    void Update()
    {
        transform.position = followtarget.position + posOffset; //The camera will follow the player every frame
        transform.LookAt(followtarget); // faces the player anytime
    }   
}
