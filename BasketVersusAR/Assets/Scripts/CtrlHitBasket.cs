using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CtrlHitBasket : MonoBehaviour
{
    public GameObject overTriggerGameObj;
    public GameObject belowTriggerGameObj;
    private TriggerBasket overTriggerBasket;
    private TriggerBasket belowTriggerBasket;
    private bool overTriggerActive = false;
    private bool belowTriggerActive = false;

    private void Start()
    {
        overTriggerBasket = overTriggerGameObj.GetComponent<TriggerBasket>();
        belowTriggerBasket = belowTriggerGameObj.GetComponent<TriggerBasket>();
    }

    public void triggerChanged()
    {
        if (overTriggerActive == true && belowTriggerActive == false)
        {
            if (belowTriggerBasket.triggerActive == true)
            {
                Debug.Log("BASKET!!!");
            }
        }
        overTriggerActive = overTriggerBasket.triggerActive;
        belowTriggerActive = belowTriggerBasket.triggerActive;
    }
    
    
    public void restartTriggers()
    {
        overTriggerActive = false;
        belowTriggerActive = false;
    }
    
}
