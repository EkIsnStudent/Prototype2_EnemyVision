using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Reduce Player Health");
            Destroy(this.gameObject);
           
        }
        else
        {
          
        }
    }
}
