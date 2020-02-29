using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour {

    public GameObject[] tilePrefabs;
    public Transform playerTransform;
    private float spawnX;
    private float spawnY = 2.75f;
    private float platformSpace = 2.75f;
    // Use this for initialization
    void Start () {
        for (int i = 0; i < 5; i++)
        {
            SpawnTile();
        }
    }
	
	// Update is called once per frame
	void Update () {
		if (playerTransform.position.y > (spawnY - 5 /* amount of tiles on screen*/* platformSpace)) {
            SpawnTile();
        } 
	}

    private void SpawnTile(int prefabIndex = -1)
    {
        spawnX = Random.Range(-1.9f, 1.9f); 
        GameObject go = Instantiate(tilePrefabs[0]) as GameObject;
        go.transform.SetParent(transform);
        go.transform.position = new Vector3(spawnX, 1 * spawnY, 0);
        spawnY += platformSpace;
        Debug.Log(spawnY);
    }
} 
