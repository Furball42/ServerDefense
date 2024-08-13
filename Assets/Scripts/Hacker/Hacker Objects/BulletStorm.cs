using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletStorm : MonoBehaviour, IHackerSet
{
    //fires off 10 bullets
    //spread over all lanes
    public int NumberOfShots = 7;
    public float TimeBetweenShots = 0.5f;
    public int CurrentShotIndex = 0;
    public Lane[] LaneData;
    public int LastLaneIndex = 0;
    public string hackerObjectName = "BulletPhysical";

    public void StartFiring(Lane[] laneData) {

        LaneData = laneData;

        StartCoroutine(FireProcess());
    }

    IEnumerator FireProcess() {
        //check if any bullets remaining
        //if so, get index of lane
        //get lane spawn object
        //fire off Bullet

        for(var i = 0; i < NumberOfShots - 1; i++) {
            var spawnTile = LaneData[LastLaneIndex].SpawnPointTile;
            Spawner(spawnTile);

            LastLaneIndex++;
            if (LastLaneIndex > LaneData.Length - 1)
            {
                LastLaneIndex = 0;
            }

            yield return new WaitForSeconds(TimeBetweenShots);
        }
    }

    void Spawner(Tile spawnTile){
        //determine spawn position
        var spawnObject = spawnTile.transform.GetChild(0);
        var spawnPosition = spawnObject.transform.position + new Vector3(0, 0.5f, 0);

        var newObject = Instantiate(Resources.Load("Hacker Objects/" + hackerObjectName) as GameObject, spawnPosition, Quaternion.Euler(0, 0, -90));
        newObject.transform.parent = spawnTile.transform;
    }
}
