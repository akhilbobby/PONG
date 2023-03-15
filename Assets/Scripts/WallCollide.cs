using System;
using System.Collections;
using System.Collections.Generic;
using Unity.IO.LowLevel.Unsafe;
using UnityEngine;

public class WallCollide : MonoBehaviour
{
    protected virtual void Score() { }

    //public static event EventHandler OnWallCollide;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Ball ball = collision.gameObject.GetComponent<Ball>();  

        if (ball != null)
        {
            //fire OnWallsCollide event
            //OnWallCollide?.Invoke(this, EventArgs.Empty);
            Score();
            
        }
    }
}





