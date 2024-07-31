using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IServer : ISysOpObject
{
    int CPUTotal { get; set; }
    int CPURefreshRate { get; set; }
    int MemoryUnits { get; set; }
}
