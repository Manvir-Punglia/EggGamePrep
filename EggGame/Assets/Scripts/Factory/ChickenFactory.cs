using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenFactory : IFactory
{
    private GameObject _chickenPrefab;
    
    public ChickenFactory(GameObject chickenPrefab)
    {
        _chickenPrefab = chickenPrefab;
    }
    
    public GameObject CreateProduct()
    {
        return GameObject.Instantiate(_chickenPrefab);
    }
}

