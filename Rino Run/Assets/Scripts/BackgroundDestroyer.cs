using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundDestroyer : MonoBehaviour {
    private GameObject destroyBackground;
	// Use this for initialization
	void Start () {
        destroyBackground = GameObject.Find("Main Camera");
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.y + 10 < destroyBackground.transform.position.y && (transform.name == "Background 1(Clone)" || transform.name == "background2(Clone)" )) //change background 1 according to the name of the background *note: add an or statement for any additional backgrounds 
        {
            Destroy(gameObject);
        }
        
	}
}
