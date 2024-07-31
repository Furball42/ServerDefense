using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HackerObject : MonoBehaviour
{
    public string Name;
    public HackerObjecType[] ObjectTypes;
    public DamageType[] DamageTypes;
    public int Cost;
    public int Damage;
    public float Speed;
    public int Level;

    public virtual void ActionOnHit() {}

    public virtual void SetSpeed (float speed){
        Speed = speed;
    }
}
