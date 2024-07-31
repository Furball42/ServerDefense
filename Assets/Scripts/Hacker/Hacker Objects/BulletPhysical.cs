using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPhysical : HackerObject
{
    public ISysOpObject targetObjectScript;

    void Update() 
    {
        transform.Translate(Vector3.up * Time.deltaTime * base.Speed);
    }

    private void OnCollisionEnter(Collision target) {
        
        //TODO: should probably check if collision target is firewall or server
        if (target != null)  {
            targetObjectScript = (ISysOpObject)target.gameObject.GetComponent<ISysOpObject>();
            targetObjectScript.TakeHPDamage(base.Damage, base.DamageTypes);
        }
        
        Destroy(gameObject);
    }
}
