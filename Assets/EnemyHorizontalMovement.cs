using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHorizontalMovement : MonoBehaviour
{

    public float speed = 2f;
    public bool left = true;


    private Rigidbody2D rbody;


    // Use this for initialization
    void Start()
    {   // kallar på rigidbodyn av råttan/råttorna.
        rbody = GetComponent<Rigidbody2D>();
    }


    // FIxedUpdate is called once per frame
    void FixedUpdate()
    {
        // att vänster e sant tills att råttan/orna träffar någonting.
        if (left == true)
        {
            rbody.velocity = (-(Vector2)transform.right * speed);
            transform.localScale = new Vector3(1, 1, 1);
        }

        // att om vänster inte e sant går råttan/orna till höger.
        else
        {
            rbody.velocity = ((Vector2)transform.right * speed);
            transform.localScale = new Vector3(-1, 1, 1);
        }

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        // att när råttan/orna träffar en InvisibleWall byter dom riktning.
        if (collision.tag == "InvisibleWall")
        {
            left = !left;
        }
    }

}
