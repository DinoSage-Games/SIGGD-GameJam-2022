using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldCommand : Command
{
    private GameObject target;


    public ShieldCommand(GameObject target)
    {
        this.target = target;

    }
    public void Execute()
    {
        Debug.Log(target);
        target.GetComponent<ShieldStat>().decreaseShield();
        target.GetComponent<ShieldStat>().updateShieldUI();
    }

}
