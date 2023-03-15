using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerWall : WallCollide
{
    protected override void Score()
    {
        GameManager.instance.ComputerWall();
    }
}
