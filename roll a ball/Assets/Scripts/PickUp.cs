using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public float rotateSpeed = 5;

    // when an object hits this
   private void OnTriggerEnter(Collider other) 
   {
        if (other.CompareTag("Player")) // If the object that just this is the player
        {
            // then this object dissapears
            Destroy(gameObject);
        }
   }
    
    private void Update()
    {
        // Every frame we want our pick ups to rotate
        transform.Rotate(new Vector3(rotateSpeed,rotateSpeed,rotateSpeed) * Time.deltaTime);
    }
    
    
}
