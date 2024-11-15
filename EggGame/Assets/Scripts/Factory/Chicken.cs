using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken : Subject
{
    private  static ChickenData chickenData;
    public ChickenDisplay display;
    private Rigidbody rb;

    public void Initialize(ChickenData sharedData)
    {
        chickenData = sharedData;
    }

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        chickenData = GameObject.Find("GameManager").GetComponent<ChickenData>();
        display = GameObject.Find("GameManager").GetComponent<ChickenDisplay>();
        Attach(display);
    }

    private void OnEnable()
    {
         //Attach(display);
    }

    private void OnDisable()
    {
        Detach(display);
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        if (ChickenData.target != null)
        {
            Vector2 direction = (ChickenData.target.position - transform.position).normalized;


            rb.velocity = direction * ChickenData.speed;
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Barn")
        {
            NotifyObservers();
            Destroy(this.gameObject);
        }

       
    }
}