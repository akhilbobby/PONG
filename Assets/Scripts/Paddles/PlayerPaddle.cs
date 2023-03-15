using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPaddle : PlayerParent
{
    [SerializeField] private GameInput gameInput;

    Vector2 paddleDirection = new Vector2(0, 0);

    private void Update()
    {
        paddleDirection = gameInput.GetMovement();
    }

    private void FixedUpdate()
    {
        if(paddleDirection.sqrMagnitude > 0)
        {
            MovePaddle(this.paddleDirection);
        }
    }

}
