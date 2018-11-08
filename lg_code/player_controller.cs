//人物基本操作：移动、转向、跳跃
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour {

    private Rigidbody2D rig;
    public float moveSpeed;
    public float jumpSpeed;
    private bool playerjump = false;
    private float direction = 0;

    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        //人物跳跃
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (!playerjump)
            {
                rig.velocity = new Vector2(rig.velocity.x, rig.velocity.y+jumpSpeed);
                playerjump = true;
            }
        }
        //人物转向
        direction = Input.GetAxis("Horizontal");
        if(direction<0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
        else if (direction>0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        //人物移动
       rig.velocity = new Vector2(moveSpeed * Input.GetAxis("Horizontal"), rig.velocity.y);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Floor")

        {
            playerjump= false;//防止二段跳
        }
    }

}
