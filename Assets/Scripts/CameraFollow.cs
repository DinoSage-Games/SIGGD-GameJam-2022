using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] GameObject player;
    //private float groundLevel = 0;

    // Start is called before the first frame update
    void Start()
    {
        //groundLevel = -1 * this.GetComponent<Camera>().orthographicSize;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerpos = player.transform.position;
        this.transform.position = new Vector3(playerpos.x, Mathf.Max(playerpos.y, 0), this.transform.position.z);
        Debug.Log("Player y: " + playerpos.y);
    }
}
