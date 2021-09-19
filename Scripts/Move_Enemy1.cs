using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Enemy1 : MonoBehaviour
{
    float speed;
    float radius = 0.001f;

    private void Start()
    {
        speed = Random.Range(0f, 1.0f);
    }
    void Update()
    {
        float x = transform.position.x + radius * Mathf.Sin(Time.time * speed);
        transform.position = new Vector3(x, transform.position.y, transform.position.z);
    }

}
