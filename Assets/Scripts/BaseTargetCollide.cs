using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseTargetCollide : MonoBehaviour
{
    [SerializeField] private GameObject[] bases;
    [SerializeField] float speed;
    [SerializeField] public float dmg;


    private GameObject target;
    private Vector2 targetPoint;
    private Rigidbody2D body;

    void Start()
    {
        // Define Instance Variables
        target = bases[Random.Range(0, bases.Length)];
        Debug.Log(target == null);
        body = this.GetComponent<Rigidbody2D>();

        // Define Target Point
        Vector2 center = target.transform.position;
        BoxCollider2D collider = this.GetComponent<BoxCollider2D>();
        float x = Random.Range(center.x - (collider.size.x / 2), center.x + (collider.size.x / 2));
        float y = Random.Range(center.y - (collider.size.y / 2), center.y + (collider.size.y / 2));

        targetPoint = new Vector2(x, y);
    }

    void Update()
    {
        if (body == null)
        {
            body = this.GetComponent<Rigidbody2D>();
        }
        // Find Direction to Target
        float dirX = targetPoint.x - this.transform.position.x;
        float dirY = targetPoint.y - this.transform.position.y;

        // Normalizes Vector
        Vector2 dir = new Vector2(dirX, dirY);
        dir = dir.normalized * speed;

        // Updates Velocity Accordingly
        body.velocity = dir;

        // Update Missile Rotation
        //transform.eulerAngles = (new Vector3(dir.x, dir.y));
        transform.rotation = Quaternion.LookRotation(new Vector3(dir.x, dir.y)) * Quaternion.FromToRotation(Vector3.right, Vector3.forward);
    }

    void LateUpdate()
    {
        transform.Rotate(Vector3.forward, 90);
    }

    // Destroys missile on collision and damages target
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("COLLIDE!");
        //Check for a match with the a base with the "Base" tag
        if (collision.gameObject.tag == "Base")
        {
            DamageCommand dmgC = new DamageCommand(target, dmg);
            dmgC.Execute();
            Destroy(this.gameObject);
        }
    }
}