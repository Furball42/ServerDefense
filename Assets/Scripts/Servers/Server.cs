using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Server : MonoBehaviour, IServer, IObject
{
    public string Name { get; set; }
    public int Integrity { get; set; }
    public int CPU { get; set; }
    public int MemoryUnits { get; set; }

    private void OnCollisionEnter(Collision other) {        
        ActionOnHit();
    }

    public virtual void ActionOnHit() {}

    public virtual void ActionOnDestroyed() {}

    public void TakeHPDamage(int damage, DamageType[] damageTypes) {      
        Debug.Log("Server - TakeHPDamage");
        Integrity -= damage;

        if (Integrity <= 0) {
            Debug.Log("Game Over");
            Destroy(gameObject);
        }
    }
}
