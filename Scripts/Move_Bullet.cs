using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Bullet : MonoBehaviour
{
    public GameObject target;
    Vector3 direction;
    float speed = 10.0f;

    public void Start()
    {
        //【追加】Destoryを5.0f後指定で追加
        Destroy(this.gameObject, 5.0f);
        //Targetオブジェクトを探して自動的に取得
        target = GameObject.Find("Target").gameObject;
        direction = target.transform.position;
    }

    public void Update()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, direction, step);
    }
}
