using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {
    public Transform view; //drag in rhino sprite
    private Vector3 offset = new Vector3(0, 0, 6.5f); 
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = view.transform.position - offset;
	}
}
