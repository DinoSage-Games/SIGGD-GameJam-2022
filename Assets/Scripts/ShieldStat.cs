using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldStat : MonoBehaviour
{
    [SerializeField] int shields;

    public void Hurt(int amount)
    {
        shields -= amount;
    }

    public float getShields()
    {
        return shields;
    }
}
