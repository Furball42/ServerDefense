using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISysOpObject
{
    string Name { get; set; }
    int Integrity { get; set; }
    void TakeHPDamage(int damage, DamageType[] damageTypes);
}
