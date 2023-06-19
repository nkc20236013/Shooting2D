using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PreyerContller : MonoBehaviour
{
    Vector3 dir = Vector3.zero;

    Animator anim;

    void Start()
    {
        //�A�j���[�^�[�R���|�[�l���g�̏������L
     
        anim = GetComponent<Animator>();
    }

    
    void Update()
    {
        float speed = 5;
        dir.x = Input.GetAxisRaw("Horizontal");
        dir.y = Input.GetAxisRaw("Vertical");

        transform.position += dir * speed * Time.deltaTime;


        if(dir.y == 0)
        {
            anim.Play("Pleyer");
        }
        else if(dir.y == 1)
        {
            anim.Play("PlayerL");
        }
        else if(dir.y == -1)
        {
            anim.Play("PlayerR");
        }
        //��ʓ��ړ�����
        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, -9f, 9f);
        pos.y = Mathf.Clamp(pos.y, -5f, 5f);
        transform.position = pos;

        //�A�j���[�V�����ݒ�
    }
}
