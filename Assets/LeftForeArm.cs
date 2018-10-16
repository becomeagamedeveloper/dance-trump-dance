using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftForeArm : MonoBehaviour {

    public ManagerGame gm;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Star")
        {
            Destroy(collision.gameObject);
            gm.AddScore(1);
        }
    }
}
