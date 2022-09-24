using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class MissileSpawn : MonoBehaviour
{
    [SerializeField] GameObject missileTemplate;
    [SerializeField] int delay = 0;

    GameObject[] bases;
    int missileCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        bases = GameObject.FindGameObjectsWithTag("Base");
        StartCoroutine(SpawnMissile());
    }

    IEnumerator SpawnMissile()
    {
        for(;;)
        { 
            yield return new WaitForSeconds(Mathf.Max(delay, 1));

            float posX = Random.Range(-9, 9);
            GameObject missile = Instantiate(missileTemplate);
            missile.GetComponent<BaseTargetCollide>().target = bases[Random.Range(0, bases.Length)];

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
