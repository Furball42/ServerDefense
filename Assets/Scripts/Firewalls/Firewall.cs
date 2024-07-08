using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firewall : MonoBehaviour
{
    public string Name;
    public DamageType[] ResistTypes;
    public int HP;
    public int Cost;

    public virtual void ActionOnHit() {}

    public virtual void ActionOnDestroyed() {}

    public void TakeHPDamage(int damage, DamageType damageType) {
        
        var resisted = false;
        Debug.Log("Damage Type: " + damageType.ToString());

        foreach(var resist in ResistTypes)
        {
            Debug.Log("Resist Type: " + resist.ToString());
            if (resist == damageType)
            {
                resisted = true;
            }
        }

        if (!resisted){
            HP -= damage;
        }

        Debug.Log("Is resisted: " + resisted.ToString());
    }
}
