using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : Object
{
    public Firewall targetScript;

    void Start()
    {

    }

    void Update() 
    {
        transform.Translate(Vector3.up * Time.deltaTime * base.Speed);
    }

    private void OnCollisionEnter(Collision other) {
        
        //TODO: should probably check if collision target is firewall
        if (other != null)  {
            targetScript = (Firewall)other.gameObject.GetComponent("PicketFence");
            targetScript.TakeHPDamage(base.Damage, base.DamageTypes);
        }
        
        Destroy(gameObject);
    }
}
