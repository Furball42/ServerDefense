using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IFirewall : ISysOpObject
{
    DamageType[] ResistTypes { get; set; }
    int MemoryCost { get; set; }
    int CPUCost { get; set; }
}
