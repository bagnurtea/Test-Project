 using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;
 
 
 public class DeathReSpawn : MonoBehaviour
{
    public Transform spawnPosition;
    Rigidbody body;

    void Start()
    {
        GetComponent<Rigidbody>();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Death")
        {
            transform.position = spawnPosition.position;
            body.velocity = Vector3.zero;
        }
    }
}