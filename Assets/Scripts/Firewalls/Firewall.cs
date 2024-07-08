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
}
