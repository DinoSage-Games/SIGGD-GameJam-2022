using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WaveSystem : MonoBehaviour
{
    int currIndex = 0;
    [SerializeField] GameObject[] waves;
    GameObject[] bases;

    // Start is called before the first frame update
    void Start()
    {

        // Define Bases
        bases = GameObject.FindGameObjectsWithTag("Base");

        Debug.Log("Bases size: " + bases.Length);

        // First Wave
        GameObject w1 = Instantiate(waves[currIndex]);
        WavePoint w1_wp = w1.GetComponent<WavePoint>();
        w1_wp.Set(w1.GetComponent<BasicMissile>());
        

        // Set First Wave
        Debug.Log("RUN");
    }

    // Update is called once per frame
    void Update()
    {
        if(true)
        {

        }
    }
    
}
