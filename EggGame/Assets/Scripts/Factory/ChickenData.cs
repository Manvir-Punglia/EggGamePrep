using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ChickenData:MonoBehaviour
{
    [SerializeField] public static Transform target;
    [SerializeField] public static float speed = 5f;

    private void Awake()
    {
        speed = 5f;
        target = GameObject.Find("Barn").transform;
    }
}
