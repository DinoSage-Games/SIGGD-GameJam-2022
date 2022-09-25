using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthStat : MonoBehaviour
{
    [SerializeField] float health;
    [SerializeField] float maxHealth;


    public void Hurt(float amount)
    {
        health -= amount;
    }

    public float getHealth()
    {
        return health;
    }

    public void setMaxHealth(float maxHealthInput)
    {
        maxHealth = maxHealthInput;
    }
    public float getMaxHealth()
    {
        return maxHealth;
    }

}
