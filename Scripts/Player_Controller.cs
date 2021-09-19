using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{

    public float rotSpeed = 1.0f;
    float rotX = 0.0f, rotY = 0.0f;

    void FixedUpdate()
    {
        // Read input 
        float axisH = Input.GetAxis("Horizontal");
        float axisV = Input.GetAxis("Vertical");

        rotX += axisV * rotSpeed;
        rotY -= axisH * rotSpeed;

        rotX = Mathf.Clamp(rotX, -90.0f, 90.0f);
        while (rotY < 0.0f) { rotY += 360.0f; }
        while (rotY > 360.0f) { rotY -= 360.0f; }

        transform.eulerAngles = new Vector3(-rotX, -rotY, 0.0f);
    }
}