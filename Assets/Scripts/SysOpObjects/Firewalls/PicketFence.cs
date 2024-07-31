using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PicketFence : Firewall
{
    void Start() {        
        base.Name = "Picket Fence";
        base.HP = 5;
        base.Cost = 2;
        base.ResistTypes = new DamageType[] {DamageType.Electro};
    }
}
