using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class ChickenSpawner : MonoBehaviour
{
    [FormerlySerializedAs("buildingPrefabs")]
    public GameObject[] chicPrefabs;

    public Transform spawnPoint;
    IFactory fac;

    void Awake()
    {
        int rand = Random.Range(0, chicPrefabs.Length);


        IFactory fac = new ChickenFactory(chicPrefabs[rand]);

        GameObject _Chicken = fac.CreateProduct();


        _Chicken.transform.position = spawnPoint.position;
        _Chicken.transform.rotation = spawnPoint.rotation;
        
    }

    public void Spawn()
    {
        int rand = Random.Range(0, chicPrefabs.Length);
        IFactory fac = new ChickenFactory(chicPrefabs[rand]);
        GameObject _Chicken = fac.CreateProduct();
        _Chicken.transform.position = spawnPoint.position;
        _Chicken.transform.rotation = spawnPoint.rotation;
        Debug.Log("Final");
    }
}