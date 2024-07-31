using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lane : MonoBehaviour
{
    public string Name;
    public int Index;
    public Firewall[] Firewalls; //indexed from closest to server
}
