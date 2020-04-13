using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public GameObject ball;
    Vector3 distanceBetween;
    void Start()
    {
        distanceBetween = transform.position - ball.transform.position;
    }


    void LateUpdate()
    {
        transform.position = ball.transform.position + distanceBetween;
    }
}
