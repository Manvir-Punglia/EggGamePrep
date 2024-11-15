using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : Command
{
    private ChickenSpawner _controller;
    public Spawn(ChickenSpawner controller)
    {
        _controller = controller;
    }
    public override void Execute()
    {
        _controller.Spawn();
        Debug.Log("Spawn finished");
    }
}
