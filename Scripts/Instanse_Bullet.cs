using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instanse_Bullet : MonoBehaviour
{
    public float timeOut = 1.0f;
    private float timeElapsed;
    public GameObject cube;
    public GameObject Player;

    void Update()
    {
        //timeElapsedに経過時間(Time.deltaTime)を加算 
        timeElapsed += Time.deltaTime;
        if (timeElapsed >= timeOut)
        {
            //InstantiateでGameObject生成 
            //Instantiate(複製するGameObject,位置,回転)の順番で記載 
            Instantiate(cube, Player.transform.position, Quaternion.identity);
            //timeElapsedを0.0fに戻す 
            timeElapsed = 0.0f;
        }
    }
}
