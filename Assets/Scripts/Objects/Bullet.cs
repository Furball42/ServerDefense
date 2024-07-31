using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : Object
{
    public IObject targetScript;

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

            var targetObject = other.gameObject;
            targetScript = (IObject)other.gameObject.GetComponent<IObject>();
            Debug.Log(targetScript);
            targetScript.TakeHPDamage(base.Damage, base.DamageTypes);
        }
        
        Destroy(gameObject);
    }
}
