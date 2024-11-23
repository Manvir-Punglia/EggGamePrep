using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class ChickenSpawner : Singleton<ChickenSpawner>
{
    public GameObject[] chicPrefabs;

    public Transform spawnPoint;
    IFactory fac;

    public List<GameObject> chickenInstances = new List<GameObject>();

    void Awake()
    {
        IFactory fac = new ChickenFactory(chicPrefabs[0]);

        GameObject _Chicken = fac.CreateProduct();


        _Chicken.transform.position = spawnPoint.position;
        _Chicken.transform.rotation = spawnPoint.rotation;

        chickenInstances.Add(_Chicken);
    }

    public void Spawn()
    {
        int rand = Random.Range(0, 10);
        int result = 0;
        if (rand == 0) result = 1;
        if (rand > 0) result = 0;
        
        IFactory fac = new ChickenFactory(chicPrefabs[result]);
        GameObject _Chicken = fac.CreateProduct();
        _Chicken.transform.position = spawnPoint.position;
        _Chicken.transform.rotation = spawnPoint.rotation;
        Debug.Log("Final");
        if (result == 0)
        {
            chickenInstances.Add(_Chicken);
        }
    }
}