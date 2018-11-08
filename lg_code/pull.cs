using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pull : MonoBehaviour {
    private Vector3 offset;
    private Vector3 ppos;//玩家位置
    private int judge=0;
    public GameObject player;
    // Use this for initialization
    void Start()
    {
    }
    void Update()
    {
    }
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.E)&&judge==1)
        {
            transform.position = player.transform.position + offset;
        }
    }
    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            offset = transform.position - player.transform.position;
            judge = 1;
        }

    }
   void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
           judge = 0;
        }
    }
   
}
