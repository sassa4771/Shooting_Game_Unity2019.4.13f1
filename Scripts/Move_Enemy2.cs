using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Enemy2 : MonoBehaviour
{
    float speed;
    float radius = 0.005f;

    private void Start()
    {
        speed = Random.Range(0f, 2.0f);
    }
    void Update()
    {
        float x = transform.position.x + radius * Mathf.Sin(Time.time * speed);
        float z = transform.position.z + radius * Mathf.Sin(Time.time * speed);
        transform.position = new Vector3(x, transform.position.y, z);
    }
}
