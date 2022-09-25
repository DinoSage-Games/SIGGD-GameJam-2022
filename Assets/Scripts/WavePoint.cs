using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WavePoint : MonoBehaviour
{
    Missile[] missiles;
    GameObject[] bases;

    public void Set(GameObject[] bases, params Missile[] missiles)
    {
        // Initialize Instance Variables
        this.missiles = missiles;
        this.bases = bases;
    }

    void Start()
    {
        foreach (Missile m in missiles)
        {
            m.Load();
            StartCoroutine(m.SpawnMissile(bases[Random.Range(0, bases.Length)]));
        }
    }

    void Update()
    {
        bool nullcheck = true;
        foreach (Missile m in missiles)
        {
            if(m != null)
            {
                nullcheck = false;
                break;
            }
        }

        if (nullcheck)
        {
            Destroy(this);
        }
    }
}
