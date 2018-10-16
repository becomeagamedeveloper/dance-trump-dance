using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trump : MonoBehaviour {

    public float x_speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        transform.Translate(Input.GetAxis("Horizontal") * x_speed, 0, 0);
	}


}
