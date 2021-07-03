using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject HackerObject;
    public GameObject HackerSpawnTile;

    // Start is called before the first frame update
    void Start()
    {
        SpawnObjectForHacker();
    }

    public void SpawnObjectForHacker(){
        //determine spawn position
        var spawnObject = HackerSpawnTile.transform.GetChild(0);
        var spawnPosition = spawnObject.transform.position + new Vector3(0, 0.5f, 0);


        Debug.Log(spawnPosition);
        var newObject = Instantiate(HackerObject, spawnPosition, Quaternion.Euler(0, 0, -90));
        newObject.transform.parent = HackerSpawnTile.transform;
    }
}
