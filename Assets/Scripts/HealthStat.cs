using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthStat : MonoBehaviour
{
    [SerializeField] float health;

    public void Hurt(float amount)
    {
        health -= amount;
    }

    public float getHealth()
    {
        return health;
    }
}
