using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PicketFence : Firewall
{
    private void OnCollisionEnter(Collision other) {        
        ActionOnHit();
    }

    public override void ActionOnHit() {
        base.TakeHPDamage(1, DamageType.Physical);
    }
}
