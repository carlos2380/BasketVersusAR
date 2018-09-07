using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CtrlBall : MonoBehaviour
{
    private Rigidbody rigidBody;

	// Use this for initialization
	void Start ()
	{
	    rigidBody = GetComponent<Rigidbody>();
	    rigidBody.AddForce(0f, 0, 80f);

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
