using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageCommand : Command
{
    private GameObject target;
    private float dmg;
    public DamageCommand(GameObject target, float dmg)
    {
        this.target = target;
        this.dmg = dmg;
    }


    public void Execute()
    {
        target.GetComponent<HealthStat>().Hurt(dmg);
    }

    public void damageShield()
    {
        target.GetComponent<ShieldStat>().decreaseShield();
    }
}
