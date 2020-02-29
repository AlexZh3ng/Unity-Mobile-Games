using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroyer : MonoBehaviour {
    private GameObject ObstacleDestroyer;
	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
        ObstacleDestroyer = GameObject.Find("Main Camera");
        if (transform.position.y + 10 < ObstacleDestroyer.transform.position.y && (transform.name == "obstacle1(Clone)")) //change based on names || statements can be added!
        {
            Destroy(gameObject);
        }
    }
}
