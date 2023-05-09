using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLookAt : MonoBehaviour
{

    public GameObject playerObject;
    public float lookSpeed = 20f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 Direction = playerObject.transform.position - transform.position;
        Quaternion targetRotation = Quaternion.LookRotation(Direction);
        Quaternion lookAt = Quaternion.RotateTowards(transform.rotation, targetRotation, Time.deltaTime * lookSpeed);
        transform.rotation = lookAt;
    }


}
