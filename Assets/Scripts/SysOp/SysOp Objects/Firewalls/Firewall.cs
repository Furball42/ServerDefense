using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Firewall : MonoBehaviour, IFirewall
{
    public string Name { get; set; }
    public DamageType[] ResistTypes { get; set; }
    public int Integrity { get; set; }
    public int MemoryCost { get; set; }
    public int CPUCost { get; set; }

    private void OnCollisionEnter(Collision other) {        
        ActionOnHit();
    }

    public virtual void ActionOnHit() {}

    public virtual void ActionOnDestroyed() {}

    public void TakeHPDamage(int damage, DamageType[] damageTypes) {

        var resisted = true;
        var notResisted = damageTypes.Where(i => !ResistTypes.Contains(i)).ToArray();

        if (notResisted.Count() > 0) {
            resisted = false;
        }
            
        if (!resisted){
            Integrity -= damage;
            Debug.Log(Integrity);
        }
        else {
            Debug.Log("Resisted");
        }

        if (Integrity <= 0) {
            Debug.Log("Destroyed");
            Destroy(gameObject);
        }
    }
}
