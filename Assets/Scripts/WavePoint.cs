using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WavePoint : MonoBehaviour
{
    Missile[] missiles;

    public void Set(params Missile[] missiles)
    {
        // Initialize Instance Variables
        this.missiles = missiles;
    }

    void Start()
    {
        foreach (Missile m in missiles)
        {
            m.Load();
            StartCoroutine(m.SpawnMissile());
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
