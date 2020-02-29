using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBlock : MonoBehaviour {
    private float speed = 5f;
    private bool leftTranslate;
    private bool rightTranslate; 
	// Use this for initialization
	void Start () {
        leftTranslate = true; 
	}
	
	// Update is called once per frame
	void Update () {
        if (leftTranslate == true)
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
            if(transform.position.x >= 1.95f)
            {
                leftTranslate = false;
                rightTranslate = true;
            }
        }
        
        if (rightTranslate == true)
        {
            transform.Translate(speed * Time.deltaTime * -1, 0, 0);
            if(transform.position.x <= -1.95f)
            {
                rightTranslate = false;
                leftTranslate = true;
            }
        }


















 /*       if (transform.position.x <= 1.9f && leftTranslate == true && rightTranslate == false) {
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
        if (transform.position.x >= 1.9f && leftTranslate == true)
        {
            Debug.Log("hi");
            rightTranslate = true;
            leftTranslate = false;
        }
        if (rightTranslate == true && leftTranslate == false)
        {
            Debug.Log("hello word");
            Debug.Log(leftTranslate);
            transform.Translate(speed * Time.deltaTime * -2, 0, 0);
            rightTranslate = false;
            leftTranslate = true; 
        } */
	}
}
