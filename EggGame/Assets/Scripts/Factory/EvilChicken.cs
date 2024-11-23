using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvilChicken : MonoBehaviour
{
    public ChickenSpawner _spawner;
    private Rigidbody rb;
    private GameObject nearestChicken;

    // Start is called before the first frame update
    void Start()
    {
        _spawner = (ChickenSpawner)FindObjectOfType(typeof(ChickenSpawner));
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        nearestChicken = FindNearestChicken();
        if (nearestChicken != null)
        {
            
            Vector3 direction = (nearestChicken.transform.position - transform.position).normalized;

            
            rb.velocity = direction * 6f;
        }
        if (nearestChicken == null)
        {
            
            Destroy(gameObject);
            return; // Stop further execution in this frame
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    private GameObject FindNearestChicken()
    {
        GameObject nearest = null;
        float shortestDistance = Mathf.Infinity;
        foreach (GameObject chicken in _spawner.chickenInstances)
        {
            float distance = Vector3.Distance(transform.position, chicken.transform.position);
            if (distance < shortestDistance)
            {
                shortestDistance = distance;
                nearest = chicken;
            }
        }

        return nearest;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Chicken"))
        {
            Debug.Log("Evil Chicken collided with a Chicken!");

            // Destroy the chicken on collision
            _spawner.chickenInstances.Remove(collision.gameObject);
            Destroy(collision.gameObject);
           

            // Clear the reference to avoid NullReferenceException
            if (collision.gameObject == nearestChicken)
            {
                nearestChicken = null;
            }
        }
    }
}

