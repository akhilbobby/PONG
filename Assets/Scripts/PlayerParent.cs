using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerParent : MonoBehaviour
{
    private float paddleSpeed = 10f;

    protected Rigidbody2D rigidBody;

    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    public void MovePaddle(Vector2 paddleDirection)
    {
        rigidBody.AddForce(paddleDirection * this.paddleSpeed);
    }
}
