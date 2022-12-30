using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk : MonoBehaviour
{
    public Transform vrCamera;
    public float speed = 5.0f;

    private bool moveForward;
    private CharacterController cc;
    private float currentAngle;
    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        currentAngle = vrCamera.eulerAngles.x;

        if (currentAngle >= 15.0f && currentAngle < 90.0f)
            moveForward = true;
        else
        {
            moveForward = false;
        }

        if (moveForward)
        {
            Vector3 forward = vrCamera.TransformDirection(Vector3.forward);
            cc.SimpleMove(forward * speed);
        }
    }
}
