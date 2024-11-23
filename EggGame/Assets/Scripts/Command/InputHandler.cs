using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    private Invoker _invoker;
    private bool _isReplaying;
    private bool _isRecording;
    private ChickenSpawner _chickenSpawner;
    private Command _buttonA; 
    
    void Start()
    {
        _invoker = gameObject.AddComponent<Invoker>();
        _chickenSpawner = FindObjectOfType<ChickenSpawner>();
        _buttonA = new Spawn(_chickenSpawner);
        
    }

    private void Update()
    {
        if (Input.anyKeyDown)
            _invoker.ExecuteCommand(_buttonA);
        Debug.Log("part1");
    }
}
