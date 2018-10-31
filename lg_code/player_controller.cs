// lg

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p : MonoBehaviour
{

    private Rigidbody2D rig;
    private float jumpForce;//上跳所用的力
    private float moveSpeed;//移动速度
    bool playerjump = false;

    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        jumpForce = 400f;
        moveSpeed = 5.5f;

    }

    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!playerjump)
            {
                rig.AddForce(new Vector2(0, jumpForce));
                playerjump = true;
            }
        }
        rig.velocity = new Vector2(moveSpeed * Input.GetAxis("Horizontal"), rig.velocity.y);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Floor")//防止二段跳
        {
            playerjump = false;
        }
    }
}


