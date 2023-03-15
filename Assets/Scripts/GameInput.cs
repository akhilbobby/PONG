using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInput : MonoBehaviour
{
    private PaddleInput paddleInput;
    private void Awake()
    {
        paddleInput = new PaddleInput();
        paddleInput.Paddle.Enable();
    }

    public Vector2 GetMovement()
    {
        Vector2 paddleDirection = paddleInput.Paddle.Move.ReadValue<Vector2>();
        
        return paddleDirection;
    }
}
