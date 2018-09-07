using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CtrlBall : MonoBehaviour
{
    private Rigidbody rigidBody;
    private Vector3 initPosition = new Vector3();
    private const float timeToInit = 5f;
    private float timer = timeToInit;

	// Use this for initialization
	void Start ()
	{
	    rigidBody = GetComponent<Rigidbody>();
	    initPosition = transform.position;
        rigidBody.AddForce(0f, 0, 80f);
	}
	
	// Update is called once per frame
	void Update ()
	{
	    timer -= Time.deltaTime;

	    if (transform.position.y < -3f || timer < 0f)
	    {
	        timer = timeToInit;
	        transform.position = initPosition;
	        rigidBody.velocity = Vector3.zero;
            rigidBody.AddForce(0f, 0, 80f);
        }
	}
}
