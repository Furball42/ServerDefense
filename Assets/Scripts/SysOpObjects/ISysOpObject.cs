using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISysOpObject
{
    void TakeHPDamage(int damage, DamageType[] damageTypes);
}
