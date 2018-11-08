using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class climb : MonoBehaviour {
    private Rigidbody2D rig;
    public Vector3 thePosition;
    // Use this for initialization
    void Start () {
    
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
               rig = collision.gameObject.GetComponent<Rigidbody2D>();
               collision.transform.Translate(2, 3,0);//暂时写为直接改变坐标，后面还会更改（只为第一个demo所用）
            }
        }
    }
}
