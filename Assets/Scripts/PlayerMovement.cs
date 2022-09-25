using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float speedX;
    [SerializeField] private float speedY;

    private Rigidbody2D body;

    void Start()
    {
        body = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float sx = 0;
        float sy = 0;

        // Changes "To Be" Speed of Object based on what Keys are Pressed
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
            sx += 1;
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
            sx -= 1;
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
            sy += 1;
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
            sy -= 1;


        // Updates Player's Physics Body Velocity
        Vector2 v1 = new Vector2(sx, sy).normalized;
        body.velocity = new Vector2(v1.x*speedX, v1.y*speedY);

        // Switches Image Orientation Accordingly
        if (sx > 0)
        {
            this.GetComponent<SpriteRenderer>().flipX = false;
        } else
        {
            this.GetComponent<SpriteRenderer>().flipX = true;
        }
    }
}
