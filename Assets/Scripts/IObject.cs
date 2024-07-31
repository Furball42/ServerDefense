using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IObject
{
    void TakeHPDamage(int damage, DamageType[] damageTypes);
}
