using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWall : WallCollide
{
   protected override void Score()
    {
        GameManager.instance.PlayerWall();
    }
}
