using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    Rigidbody physics;
    public int speed;

    void Start()
    {
        physics = GetComponent<Rigidbody>();

    }

    void FixedUpdate()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 vec = new Vector3(horizontal,0,vertical);

        physics.AddForce(vec*speed);
        //Debug.Log("Horizontal: "+horizontal+" "+ "Vertical: "+vertical);
        
    }
}
