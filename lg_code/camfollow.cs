using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camfollow : MonoBehaviour {
    public GameObject player;
    //手动设定背景长宽高和相机尺寸
    public float camsize;
    public float width;
    public float high;
    private Vector3 offset;         
    void Start()
    {
        offset = transform.position - player.transform.position;
    }
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
        //默认相机16：9
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, camsize*16/9 - width, width-camsize*16/9), Mathf.Clamp(transform.position.y, camsize-high, high-camsize), -1);
    }
}
