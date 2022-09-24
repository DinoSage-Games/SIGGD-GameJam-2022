using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileSpawn : MonoBehaviour
{
    [SerializeField] GameObject missileTemplate;
    int missileCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnMissile());
    }

    IEnumerator SpawnMissile()
    {
        for(;;)
        { 
            yield return new WaitForSeconds(1);

            float posX = Random.Range(-9, 9);
            GameObject missile = Instantiate(missileTemplate);
            missile.transform.position = new Vector3(posX, 7, 0);

            Debug.Log("Missle Count: " + missileCount);
            missileCount++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
