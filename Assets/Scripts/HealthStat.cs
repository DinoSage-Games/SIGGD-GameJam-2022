using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthStat : MonoBehaviour
{
    [SerializeField] float health;
    [SerializeField] float maxHealth;
    SFXnMusic baseHit;

    public void Start()
    {
        baseHit = FindObjectOfType<SFXnMusic>();
        //Max health equals starting health
        maxHealth = health;
    }
    public void Hurt(float amount)
    {
        health -= amount;
        baseHit.playBaseHit();
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
