using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float moveSpeed = 6f;
    public float jumpSpeed = 12f;

    private Rigidbody2D rbody;

    public MarkKollare markkoll;


    // Use this for initialization
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // så att playern får fart och rör sig.
        rbody.velocity = new Vector2(
        Input.GetAxisRaw("Horizontal") * moveSpeed, rbody.velocity.y);
        
        //om space e ner tryckt hoppa.
        if (Input.GetButtonDown("Jump"))
        {
            //signalerar till min ground check collider att kolla så att playern är på marken så att playern kan hoppa.
            if (markkoll.isGrounded > 0)
            {   // ger playern fart uppåt så att man man hoppa.
                rbody.velocity = new Vector2(rbody.velocity.x, jumpSpeed);
            }
        }
    }
}


