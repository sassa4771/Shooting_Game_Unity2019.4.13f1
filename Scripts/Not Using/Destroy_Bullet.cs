using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_Bullet : MonoBehaviour
{
    private float currentTime;
    private float TimeOut = 5.0f;

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        if(currentTime > TimeOut)
        {
            Destroy(this.gameObject);
        }
    }
}
