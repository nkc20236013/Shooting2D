using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject enemyPre;  // 敵のプレハブを保存する変数
    float delta;                 //経過時間計算用

    void Start()
    {
        delta = 0;
    }

    void Update()
    {
        //経過時間を加算
        delta += Time.deltaTime;

        if (delta > 1f)
        {
            // 敵を生成する
            GameObject go = Instantiate(enemyPre);
            float py = Random.Range(-6f, 7f);
            go.transform.position = new Vector3(10, py, 0);

            //時間経過を保存している変数を0クリアする
            delta = 0;
        }

    }
}