using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Firewall : MonoBehaviour
{
    public string Name;
    public DamageType[] ResistTypes;
    public int HP;
    public int Cost;

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
            Debug.Log("Not resisted");
            HP -= damage;
        }
        else {
            Debug.Log("Resisted");
        }
    }
}
