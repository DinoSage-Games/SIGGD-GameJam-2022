using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] float health;

    public void Hurt(float amount)
    {
        health -= amount;
    }
}
