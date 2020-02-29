using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    private Vector3 Movement;
    private CharacterController player;
    private float verticalVelocity;
    private float gravity = 1.00f; 
	// Use this for initialization
	void Start () {
        player = GetComponent<CharacterController>();
        
	}
	
	// Update is called once per frame
	void Update () {
        if (player.isGrounded)
        {
            verticalVelocity = 20f; 
        }
        else
        {
            verticalVelocity -= gravity; 
        }
        Movement = new Vector3(Input.acceleration.x * 10, verticalVelocity, 0);
        player.Move(Movement * Time.deltaTime);
        
        
	}
}
