using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IFirewall
{
    string Name { get; set; }
    DamageType DamageType { get; set; }
    int HP { get; set; }
    int Cost { get; set; }

    void ActionOnHit();

    void ActionOnDestroyed();
}
