using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float PlayerHealth = 5;

    public void Update()
    {
        if (PlayerHealth == 0)
        {
            Debug.Log("Dead");
        }

        Debug.Log(PlayerHealth);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            PlayerHealth -= 1;
            Debug.Log("Reduce Player Health");
            Destroy(this.gameObject);           
        }
        else
        {
          
        }
    }

}
