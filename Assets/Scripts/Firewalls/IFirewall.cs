using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IFirewall : IObject
{
    string Name { get; set; }
    DamageType[] ResistTypes { get; set; }
    int HP { get; set; }
    int Cost { get; set; }
}
