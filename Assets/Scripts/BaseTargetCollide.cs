using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseTargetCollide : MonoBehaviour
{
    [SerializeField] private GameObject[] bases;
    private GameObject target;
    [SerializeField] float speed;
    public float dmg;

    void Start()
    {
        target = bases[Random.Range(0, bases.Length)];
    }

    void Update()
    {
        
    }

    // Destroys missile on collision and damages target
    void OnCollisionEnter(Collision collision)
    {
        //Check for a match with the a base with the "Base" tag
        if (collision.gameObject.tag == "Base")
        {
            DamageCommand dmg = new DamageCommand(gameObject, this.gameObject);
            dmg.Execute();
            Destroy(this);
        }
    }
}