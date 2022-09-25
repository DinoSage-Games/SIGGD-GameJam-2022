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
        float posX = 0;
        if(playerpos.x < 0)
        {
            posX = Mathf.Max(playerpos.x, -21);
        } else if (playerpos.x > 0)
        {
            posX = Mathf.Min(playerpos.x, 21);
        } else
        {
            posX = playerpos.x;
        }

        //float posX
        float posY = Mathf.Min(Mathf.Max(playerpos.y, 4), 9);
        this.transform.position = new Vector3(posX, posY, this.transform.position.z);
    }
}
