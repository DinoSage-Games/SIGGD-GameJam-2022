using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageCommand : MonoBehaviour, Command
{
    private GameObject target;
    private GameObject missile;
    public DamageCommand(GameObject target, GameObject missile)
    {
        this.target = target;
        this.missile = missile;
    }

    public void Execute()
    {
        target.GetComponent<Health>().Hurt(missile.GetComponent<BaseTargetCollide>().dmg);
    }
}
