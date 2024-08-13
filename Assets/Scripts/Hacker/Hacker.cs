using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    public int Level;
    public int Intensity; //actions / second
    public int Redirects; //nodes until found
    public Lane[] LaneData;
    public IHackerSet[] HackerSet;
    public HackerIdentity Identity;

    void Awake() {
        var go = gameObject.AddComponent(typeof(BulletStorm)) as BulletStorm;
        HackerSet = new IHackerSet[1];
        HackerSet[0] = go;
    }

    void Update() 
    {
        //just a way to test the HackerSet
        if (Input.GetKeyDown("space")) {
            Debug.Log(LaneData);
            HackerSet[0].StartFiring(LaneData);
        }
    }    
}
