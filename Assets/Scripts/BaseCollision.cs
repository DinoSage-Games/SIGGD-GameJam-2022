using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCollision : MonoBehaviour
{
    [SerializeField] private GameObject[] bases;

    void Start()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        //Check for a match with the a base with the "Base" tag
        if (collision.gameObject.tag == "Base")
        {
            Destroy(this);
        }
    }
}