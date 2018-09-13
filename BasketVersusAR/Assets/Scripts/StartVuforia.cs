using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class StartVuforia : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{
	    GetComponent<VuforiaBehaviour>().enabled = true;
	    VuforiaRuntime.Instance.InitVuforia();
    }
}
