using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{
    private const float laneDistance = 3f;
    float speed = 15f;
    GameObject player;
    public CharacterController controllr;
   // public Rigidbody rb;
    public int desiredLane = 1;


    // Update is called once per frame
    private void FixedUpdate()
    {
       //rb.AddForce(0,0,speed * Time.deltaTime);
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.K))
        {
            MoveLane(true);

           // rb.AddForce(2000*Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.R))
        {
            MoveLane(false);
        }


        Vector3 targetPosition = transform.position.z * Vector3.forward;
        if (desiredLane == 0)
        {
            targetPosition += Vector3.right * laneDistance;
        }
        else if(desiredLane == 2)
        {
            targetPosition += Vector3.left * laneDistance;
        }
        
      


        Vector3 moveVector = Vector3.zero;

        moveVector.x = (targetPosition - transform.position).normalized.x*speed;
        moveVector.y = -0.1f;
        moveVector.z = speed;
        controllr.Move(moveVector*Time.deltaTime);

        

    }
    private void MoveLane(bool goingRight)
    {
        if (!goingRight)
        {
            desiredLane++;
            if(desiredLane == 3)
            {
                desiredLane = 2;
            }
        }
        else
        {
            desiredLane--;
            if (desiredLane == -1)
            {
                desiredLane = 0;
            }
        }

    }
}
