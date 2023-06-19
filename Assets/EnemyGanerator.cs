using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject enemyPre;  // �G�̃v���n�u��ۑ�����ϐ�
    float delta;                 //�o�ߎ��Ԍv�Z�p

    void Start()
    {
        delta = 0;
    }

    void Update()
    {
        //�o�ߎ��Ԃ����Z
        delta += Time.deltaTime;

        if (delta > 1f)
        {
            // �G�𐶐�����
            GameObject go = Instantiate(enemyPre);
            float py = Random.Range(-6f, 7f);
            go.transform.position = new Vector3(10, py, 0);

            //���Ԍo�߂�ۑ����Ă���ϐ���0�N���A����
            delta = 0;
        }

    }
}