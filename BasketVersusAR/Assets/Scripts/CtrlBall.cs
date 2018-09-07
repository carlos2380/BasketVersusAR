using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Comparers;

using Vuforia;
public class CtrlBall : MonoBehaviour
{
    private Rigidbody rigidBody;
    private Vector3 initPosition = new Vector3();
    private Quaternion initRotation = new Quaternion();
    private const float timeToInit = 5f;
    private float timer = timeToInit;
    private PhysicMaterial physicMaterial;

	// Use this for initialization
	void Start ()
	{
        rigidBody = GetComponent<Rigidbody>();
        initPosition = transform.position;
	    initRotation = transform.rotation;
        rigidBody.AddForce(0f, 0, 100f);
	    physicMaterial = GetComponent<SphereCollider>().material;

	}
	
	// Update is called once per frame
	void Update ()
	{
	    timer -= Time.deltaTime;

	    if (transform.position.y < -3f || timer < 0f)
	    {
	        timer = timeToInit;
	        transform.position = initPosition;
	        transform.SetPositionAndRotation(initPosition, initRotation);

            physicMaterial.bounciness = Random.Range(0.8f, 0.9f);
	        rigidBody.velocity = Vector3.zero;
            rigidBody.AddForce(Random.Range(-30f, 30f), 0f, 100f);
        }
	}
}
