using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IServer : IObject
{
    string Name { get; set; }
    int Integrity { get; set; }
    int CPU { get; set; }
    int MemoryUnits { get; set; }
}
