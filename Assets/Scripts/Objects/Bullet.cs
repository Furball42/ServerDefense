using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : Object
{
    public float mySpeed = 5;

    void Start()
    {

    }

    void Update() 
    {
        transform.Translate(Vector3.up * Time.deltaTime * mySpeed);
    }

    private void OnCollisionEnter(Collision other) {
        Destroy(gameObject);
    }
}
