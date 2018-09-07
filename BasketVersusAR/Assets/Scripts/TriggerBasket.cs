using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBasket : MonoBehaviour
{
    [HideInInspector]
    public bool triggerActive = false;
    private CtrlHitBasket ctrlHitBasket;

    private void Start()
    {
        ctrlHitBasket = transform.parent.parent.GetComponent<CtrlHitBasket>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            triggerActive = true;
            ctrlHitBasket.triggerChanged();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        triggerActive = false;
        ctrlHitBasket.triggerChanged();
    }
}
