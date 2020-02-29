using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    private bool alive; 
    private CharacterController rhino;
    private float up = 1f;
    private Vector3 Movement;

	// Use this for initialization
	void Start () {
        alive = true;
        rhino = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
        Movement = new Vector3(0, up, 0);
        if (alive == true) 
        {
            up += 0.02f;
            rhino.Move(Movement * Time.deltaTime);
        }        
	}
}
