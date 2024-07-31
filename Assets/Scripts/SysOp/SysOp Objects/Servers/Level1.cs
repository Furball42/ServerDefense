using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1 : Server
{
    void Start() {        
        base.Name = "Level 1";
        base.Integrity = 5;
        base.CPUTotal = 100;
        base.CPURefreshRate = 5;
        base.MemoryUnits = 10;
    }
}
