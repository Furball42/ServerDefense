using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PicketFence : Firewall
{
    void Start() {        
        base.Name = "Picket Fence";
        base.Integrity = 5;
        base.MemoryCost = 2;
        base.CPUCost = 15;
        base.ResistTypes = new DamageType[] {DamageType.Electro};
    }
}
