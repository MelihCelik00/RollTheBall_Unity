using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallControl : MonoBehaviour
{
    Rigidbody physics;
    public int speed;
    int pointCounter = 0;
    public int totalLoot;
    public Text Counter;
    public Text GameOverText;

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
    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("Touched!");
        if (other.gameObject.tag == "Loot")
        {
            Destroy(other.gameObject); // eats all of the objects on the area
            pointCounter++;

            Counter.text = "Point Counter: " + pointCounter;
            //Debug.Log("Point: " + pointCounter);

            if(pointCounter == totalLoot)
            {
                //Debug.Log("YOU WIN! Game is over!");
                GameOverText.text = "Game is over, you win!";
            }
        }
        else if (other.gameObject.tag == "Capsule")
        {
            Destroy(other.gameObject);
        }
    }
}
