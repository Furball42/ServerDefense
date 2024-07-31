using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Server : MonoBehaviour, IServer, ISysOpObject
{
    public string Name { get; set; }
    public int Integrity { get; set; }
    public int CPUTotal { get; set; }
    public int CPURefreshRate {get; set;} //should probably be a different type x / second
    public int MemoryUnits { get; set; }

    private void OnCollisionEnter(Collision other) {        
        ActionOnHit();
    }

    public virtual void ActionOnHit() {}

    public virtual void ActionOnDestroyed() {}

    public void TakeHPDamage(int damage, DamageType[] damageTypes) {      
        Integrity -= damage;

        if (Integrity <= 0) {
            Destroy(gameObject);
            Debug.Log("Game Over");            
        }
    }
}
