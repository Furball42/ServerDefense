using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public Tile PreviousTile;
    public Tile NextTile;
    public bool IsHackerSpawn;
    public bool IsSysOpsSpawn;
    public bool CanHaveFirewall;
    public int FirewallExtraCost;    

    private Firewall CurrentFirewall;

}
