using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerPaddle : PlayerParent
{
    //the goal is to track the position of the ball i.e. play with rigidBody and rigidBodyBall

    [SerializeField] private Rigidbody2D rigidBodyBall;

    private void FixedUpdate()
    {
        //if ball is moving towards paddle
        if(rigidBodyBall.velocity.x > 0)
        {
            if (this.rigidBodyBall.position.y > transform.position.y)
            {
                MovePaddle(Vector2.up);
            }
            else if(this.rigidBodyBall.position.y < transform.position.y)
            {
                MovePaddle(Vector2.down); ;
            }
        }

        //ball is moving away from paddle
        else
        {
            //add a force as long as it gets close to the x axis(y=0)
            if(rigidBody.position.y > 2f)
            {
                MovePaddle(Vector2.down);
            }
            else if (rigidBody.position.y < -2f)
            {
                MovePaddle(Vector2.up);
            }
            else
            {
                //no force
            }
        }
    }
}
