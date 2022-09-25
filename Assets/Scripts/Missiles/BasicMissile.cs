using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMissile : Missile
{
    public override void Set(int count, float damage, float delay, float speed) {

    }

    // Missile Template

    public override void Load()
    {
        missileType = (GameObject) Resources.Load("Prefabs/Missile");
        missileType.GetComponent<BaseTargetCollide>().dmg = Damage;
    }

    public override IEnumerator SpawnMissile(GameObject target)
    {
        for (int i = 0; i < Count ; i++)
        {
            // Wait for "Delay" seconds before each spawn
            yield return new WaitForSeconds(Mathf.Max(delay, 1));

            // Instantiate missile
            GameObject missile = Instantiate(missileType);

            // Set Missile Position & Target
            float posX = Random.Range(-9, 9);

            missile.GetComponent<BaseTargetCollide>().target = target;
            missile.transform.position = new Vector3(posX, 7, 0);
        }
        // Dispose of this script
        Destroy(this);
    }

}
