using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomBasketFlag : MonoBehaviour
{
    private Cloth cloth;
	// Use this for initialization
	void Start ()
	{
	    cloth = GetComponent<Cloth>();
	    StartCoroutine(flag());
	}

    private IEnumerator flag()
    {
        yield return new WaitForSeconds(Random.Range(4,10));
        bool effectDone = false;
        while (effectDone == false)
        {
            float acc = Random.Range(-100, -1000);
            cloth.externalAcceleration = new Vector3(acc, acc, 0f);
            effectDone = true;
            yield return null;
        }
        cloth.externalAcceleration = new Vector3(0f, 0f, 0f);
        StartCoroutine(flag());
    }
}
