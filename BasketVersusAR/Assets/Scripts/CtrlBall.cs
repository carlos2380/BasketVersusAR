using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Comparers;

using Vuforia;
public class CtrlBall : MonoBehaviour
{
    public Vector3 forceTorque;
    private Rigidbody rigidBody;
    private Vector3 initPosition = new Vector3();
    private Quaternion initRotation = new Quaternion();
    private const float timeToInit = 5f;
    private float timer = timeToInit;
    private PhysicMaterial physicMaterial;
    private Rigidbody rigidbody;

    [Header("Sounds")]
    public AudioSource bounce;
    public AudioSource board;
    public AudioSource ring;
    public AudioSource net;

    // Use this for initialization
    void Start ()
	{
        rigidBody = GetComponent<Rigidbody>();
        initPosition = transform.position;
	    initRotation = transform.rotation;
        rigidBody.AddForce(0f, 0, 100f);
	    physicMaterial = GetComponent<SphereCollider>().material;
	    rigidbody = GetComponent<Rigidbody>();


	}
	
	// Update is called once per frame
	void Update ()
	{
	    timer -= Time.deltaTime;

	    if (transform.position.y < -3f || timer < 0f)
	    {
	        respown();
        }
	}

    
    public void respown()
    {
        timer = timeToInit;
        transform.position = initPosition;
        transform.SetPositionAndRotation(initPosition, initRotation);
        rigidbody.AddTorque(forceTorque);
        physicMaterial.bounciness = Random.Range(0.85f, 0.98f);
        rigidBody.velocity = Vector3.zero;
        rigidBody.AddForce(Random.Range(-30f, 30f), 0f, 100f);
    }

    private void OnTriggerEnter(Collider other)
    {
        switch (other.tag)
        {
            case "MainCamera":
                bounce.Play();
                break;
            case "Ring":
                ring.Play();
                break;
            case "Board":
                board.Play();
                break;
            case "Net":
                net.Play();
                break;
        }
    }
}
