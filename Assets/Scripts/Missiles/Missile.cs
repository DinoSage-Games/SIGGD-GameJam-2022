using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Missile : MonoBehaviour
{
    [SerializeField] protected GameObject missileType;
    [SerializeField] protected int Count { get; }
    [SerializeField] protected float Damage { get; }
    [SerializeField] protected float Speed { get; }

    protected float delay;

    public abstract void Load();
    public abstract void Set(int count, float damage, float speed, float delay);


    public abstract IEnumerator SpawnMissile(GameObject target);


}
