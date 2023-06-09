using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("EnemyControllerRen");
    }

    // Update is called once per frame
    void Update()
    {
        //X方向の移動
        float speed = 5f;
        Vector3 dir = Vector3.left;

        //左に見キレたら右から登場
        if(transform.position.x<-9f)
        {
            Vector3 pos = transform.position;
            pos.x = 9f;
            transform.position = pos;
        }
        //y方向の移動
        dir.x = Mathf.Sin(Time.time * 5f);
        dir.y = Mathf.Sin(Time.time * 5f);
        Debug.Log(Time.time);

        transform.position += dir.normalized * speed * Time.deltaTime; 
    }
}
