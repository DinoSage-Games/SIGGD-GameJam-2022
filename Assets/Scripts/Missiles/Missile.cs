using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Missile : MonoBehaviour
{
    [SerializeField] protected GameObject missileType;
    [SerializeField] protected int Count;
    [SerializeField] protected float Damage;
    [SerializeField] protected float Speed;

    protected float delay;

    public abstract void Load();
    public abstract void Set(int count, float damage, float speed, float delay);


    public abstract IEnumerator SpawnMissile();


}
