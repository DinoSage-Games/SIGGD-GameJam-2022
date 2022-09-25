using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WaveSystem : MonoBehaviour
{
    List<WavePoint> wavepoints;
    int currIndex = 0;
    [SerializeField] GameObject wave;
    GameObject[] bases;
    Transform parent;

    // Start is called before the first frame update
    void Start()
    {
        parent = this.transform.parent;

        // Define Bases
        bases = GameObject.FindGameObjectsWithTag("Base");

        wavepoints = new List<WavePoint>();

        // First Wave
        GameObject w1 = Instantiate();
        WavePoint w1_wp = w1.GetComponent<WavePoint>();
        w1_wp.Set()
        
        //wavepoints.Add(Instantiate(bases, parent.transform)); new BasicMissile(10, 10, 3, 1)));

        // Set First Wave
        Instantiate(wavepoints[currIndex], this.transform.parent);
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
