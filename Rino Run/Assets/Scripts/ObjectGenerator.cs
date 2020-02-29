using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Add this to a new empty called ObstacleGenerator 
public class ObjectGenerator : MonoBehaviour {
    public Transform rhino; //drag rhino sprite in 
    public GameObject[] obstacles; 
    private int ObjectsOnScreen; 
    private float GenerationStart = 10f; //change based on where obstacles should begin spawning
    private float backgroundSize = 10f; //change based on background size(blank amount of objects will spawn per background)
    private float y = 10f;
    private int backgroundCount = 3; //change based on amount of pregenerated obstacles needed
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (rhino.position.y > (y - backgroundCount * backgroundSize))
        {
            ObjectsOnScreen = Random.Range(3, 7); //3-6 objects generated per backgrounds (may vary)
            SpawnObject();
            Debug.Log(y);
        }
    }

    void SpawnObject ()
    {
        for (int i = 1; i < ObjectsOnScreen; i++)
        {
            GameObject yes = Instantiate(obstacles[0]) as GameObject;
            yes.transform.SetParent(transform);
            yes.transform.position = new Vector3(Random.Range(-3f, 4f) /*Camera position -3 is inclusive and 4 is exclusive*/, 1 * y + (Random.Range(-5f, 6f)), 0);
        }
        y += backgroundSize;
    } 
}
